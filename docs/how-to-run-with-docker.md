# 🐳 How to run with Docker

## ⏩ Quick start

1. ***Pull*** the latest image  
    ```bash
    docker pull ghcr.io/cum-foundations/tdpdne-telegram-bot
    ```

    1.1 ***Tag*** pulled image with a convinient name  
        *(for example, this instruction will use ***tdpdne-telegram-bot*** image name)*  

    ```bash
    docker tag ghcr.io/cum-foundations/tdpdne-telegram-bot:latest tdpdne-telegram-bot
    ```
2. **Run** a new container  
    ```bash
    docker run -d -e BotConfiguration__Support="your-contact-information" -e BotConfiguration__BotToken="your-bot-token" -e BotConfiguration__Donations="your-donations-details" --name tdpdne-quick-start tdpdne-telegram-bot
    ```

3. ***Tell*** your friends that you love dicks

4. ***Enjoy!*** ✨
