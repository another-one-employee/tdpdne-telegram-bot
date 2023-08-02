# 🐳 How to run with Docker

## 💦 Quick start

1. ***Pull*** the latest image  
    ```bash
    docker pull ghcr.io/cum-foundations/tdpdne-telegram-bot:latest
    ```

    1.1 ***Tag*** pulled image with a convinient name  
        *(for example, this instruction will use ***tdpdne-telegram-bot*** image name)*  

    ```bash
    docker tag ghcr.io/cum-foundations/tdpdne-telegram-bot:latest tdpdne-telegram-bot
    ```
2. **Run** a new container  
    ```bash
    docker run -d -e BotConfiguration__Support="${your-contact-information}" -e BotConfiguration__BotToken="${your-bot-token}" -e BotConfiguration__Donations="${your-donations-details}" --name tdpdne-quick-start tdpdne-telegram-bot
    ```

3. ***Tell*** your friends that you love dicks

4. ***Enjoy!*** ✨

<br>

## 🏁 Running using your own Docker image build

1. ***Clone*** the repository:  
    ```bash
    git clone https://github.com/cum-foundations/tdpdne-telegram-bot.git
    ```  

    1.1 ***Configure*** [appsettings.json](how-to-configure.md) *(you can leave it as it is)*
2. ***Build*** your image:
    ```bash
    docker build --progress=plain --no-cache -t "${your-image-name}" -f "${your-path-to-repository}\tdpdne-telegram-bot\src\TDPDNE.Telegram.Bot\Dockerfile" ${your-path-to-repository}\tdpdne-telegram-bot\src
    ```  
3. ***Run*** a new container:

- If you have configured the [appsettings.json](how-to-configure.md) and updated BotConfiguration section:
    ```bash
    docker run -d --name ${your-container-name} ${your-image-name}
    ```

- if you haven't changed the [appsettings.json](how-to-configure.md):
    ```bash
    docker run -d -e BotConfiguration__Support="${your-contact-information}" -e BotConfiguration__BotToken="${your-bot-token}" -e BotConfiguration__Donations="${your-donations-details}" --name ${your-container-name} ${your-image-name}
    ```

4. Take step 3-4 of [⏩ Quick start](https://github.com/cum-foundations/tdpdne-telegram-bot/blob/master/docs/how-to-run-with-docker.md#-quick-start)
