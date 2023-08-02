# 🔧 How to configure  

## BotConfiguration section

* `"BotToken": "{BOT_TOKEN}"`  
    Replace `{BOT_TOKEN}` with your personal one received from [BotFather](https://t.me/BotFather)  

* `"Suppor": "{SUPPORT}"`  
    Replace `{SUPPORT}` with your contact information

* `"Donations": "{DONATIONS}"`  
    Replace `{DONATIONS}` with your donations details  

### Markdown support

Properties `"BotToken"` and `"Suppor"` support Markdown.  
You can make the text **Bold**, *Italics*, add an external [link](https://youtu.be/dQw4w9WgXcQ?autoplay=1) and new lines:  

* `*` for `*bold text*`  
* `_` for `_italics text_`
* `[]()` for `[text](external-link)`
* `\n` for new line  

#### ⚠️ About new lines  
For *settings files*, **use an additional backslash** to escape the backslash (`\\n`).  
For *environment variables*, save it with a single backslash.

## WrapperConfiguration section *(💡 not necessary to update)*

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

## Serilog section

***See more:***

- [GitHub repository](https://github.com/serilog/serilog)
- [Official website](https://serilog.net/)
