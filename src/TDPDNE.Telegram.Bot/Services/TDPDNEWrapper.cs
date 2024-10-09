namespace TDPDNE.Telegram.Bot.Services;

using Abstract;
using Exceptions;
using ImageMagick;
using Serilog;
using TDPDNE.Telegram.Bot.Configs;

public class TDPDNEWrapper : ITDPDNEWrapper
{
    private readonly HttpClient _client;
    private readonly WrapperConfiguration _configuration;
    private readonly ILogger<TDPDNEWrapper> _logger;
    private readonly Random _random;

    public TDPDNEWrapper(IConfiguration configuration)
    {
        _client = new HttpClient();
        _random = new Random();
        _logger = LoggerFactory
            .Create(builder => builder.AddSerilog())
            .CreateLogger<TDPDNEWrapper>();
        _configuration = configuration
            .GetRequiredSection(WrapperConfiguration.Configuration)
            .Get<WrapperConfiguration>() ?? throw new ArgumentNullException(WrapperConfiguration.Configuration);
    }

    public async Task<Stream> GetPicture(CancellationToken cancellationToken)
    {
        var id = await GetSuccessfulId(cancellationToken);

        var response = await _client.GetAsync(
            $"{_configuration.TDPDNEImageStorageUrl}" + $"{id:D4}" + ".jpg",
            cancellationToken);

        _logger.LogInformation($"Trying to get image with id: {id} by Uri: {response.RequestMessage?.RequestUri?.AbsoluteUri}");

        var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        return RemoveBlackBorder(stream);
    }

    private async Task<int> GetSuccessfulId(CancellationToken cancellationToken)
    {
        HttpResponseMessage? response = null;
        int id;
        var attempt = 0;

        do
        {
            if (attempt++ >= _configuration.AttemptsMaxCount)
            {
                var exception = new ServiceUnavailableException("Limit of attempts has been reached", typeof(HttpResponseMessage), response);
                _logger.LogError(exception, exception.Message);
                throw exception;
            }

            id = _random.Next(_configuration.MinId, _configuration.MaxId);
            response = await _client.GetAsync($"{_configuration.TDPDNEApiUrl}" + $"{id}", cancellationToken);
        }
        while (!response.IsSuccessStatusCode);

        return id;
    }

    private Stream RemoveBlackBorder(Stream stream)
    {
        using var image = new MagickImage(stream: stream);
        image.ColorFuzz = new Percentage(_configuration.MagickFuzzPercentage);
        image.Trim();
        image.ResetPage();
        
        return new MemoryStream(image.ToByteArray());
    }
}
