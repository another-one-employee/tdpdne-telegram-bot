# TDPDNE.Telegram.Bot
![AppVeyor branch](https://img.shields.io/appveyor/build/Srul1k/tdpdne-telegram-bot/master?logo=appveyor) ![Downloads](https://img.shields.io/github/downloads/Srul1k/tdpdne-telegram-bot/1.0.0/total?color=blue&label=downloads) ![Visitor Badge](https://visitor-badge.feriirawann.repl.co?username=cum-foundations&repo=tdpdne-telegram-bot&color=blueviolet&style=for-the-badge&label=views&style=badge)

This is a simple bot for generating dickpics.

❕ *Currently, the bot uses polling to receive updates from Telegram.
Also, due to the inability to have good hardware and as a result of generating new dickpics, [this](https://api.thisdickpicdoesnotexist.com) API is temporarily used to get them.*

<details>
<summary> 🎞️ Presentation</summary>

<br>

![Usage Example](res/usage-example.gif)

</details>

<details>
<summary> ▶️ How to use</summary>

<br>

To launch the bot, you need to:

1. Download the latest release

2. Update *appsettings.json*:  
    * `"BotToken": "{BOT_TOKEN}"`  
    Replace `{BOT_TOKEN}` with your personal one received from [BotFather](https://t.me/BotFather)  

    * `"SupportContact": "{SUPPORT_CONTACT}"`  
    Replace `{SUPPORT_CONTACT}` with your contact information

    * `"Donations": "{DONATIONS}"`  
    Replace `{DONATIONS}` with your donations details  

    <br>

    <details>
    <summary> 🔧(Not necessarily) Update WrapperConfiguration</summary>

    <br>

    * `TDPDNEApiUrl`  
    The URL of the API for getting dickpics ids.  
    * `TDPDNEImageStorageUrl`  
    The URL of the API for getting dickpics images.  
    * `MagickFuzzPercentage`  
    Magick.NET configuration. Adjust the fuzz value as appropriate. But if you make it too large, your image will be trimmed too much.  
    * `AttemptsMaxCount`  
    The number of attempts to get the correct id for a dickpic. After the failure, the message *"Service is temporarily unavailable"* will be displayed.  
    * `MinId`  
    Minimum limit for obtaining a valid id.  
    * `MaxId`  
    Maximum limit for obtaining a valid id.  

    </details>

3. Launch TDPDNE.Telegram.Bot.exe *(or publish a new file to run on your OS if it's not Windows x64 and then run it)*

4. Tell your friends that you love dicks

5. Enjoy! ✨

</details>
