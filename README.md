# diDENGE-Backend

## Türkçe [TR]

Projeyi çalıştırmak için herhangi bir SDK, framework kurmanıza gerek yoktur.
Gerekenler :

- Docker

### Yapılacaklar

- <b>Ana</b> konumunda .env dosyası oluşturun ve bu dosyanın içerisine aşağıdaki bilgileri girin: <br/>
  ```plaintext
    CLOUDINARY_API_SECRET=SENIN_CLOUDINARY_API_SECRET_DEGERIN
    CLOUDINARY_API_KEY=SENIN_CLOUDINARY_API_ANAHTARIN
    CLOUDINARY_CLOUD_NAME=SENIN_CLOUDINARY_CLOUD_ADIN
  ```
- Projenin dizininde terminali açın.
- `docker compose build` komutunu yazarsak projedeki gerekli image dosyalarını yükler
- `docker compose create` komutunu yazarsak container ları oluşturur
- `docker compose start` komutunu yazarsak container ları çalıştırır

### Port numaraları

WebAPI port numarası : <b>5178</b> <br/>
MSSQL Server port numarası : <b>1433</b>

## English [EN]

To run the project, you don't need to install any SDK or framework.

Requirements:

- Docker

### Steps to Perform

- Create a .env file in the <b> main </b> directory and enter the following information into this file: <br/>
  ```plaintext
    CLOUDINARY_API_SECRET=YOUR_CLOUDINARY_API_SECRET_VALUE
    CLOUDINARY_API_KEY=YOUR_CLOUDINARY_API_KEY_VALUE
    CLOUDINARY_CLOUD_NAME=YOUR_CLOUDINARY_CLOUD_NAME_VALUE
  ```
- Open the terminal in the project directory.
- If you write the command `docker compose build`, it installs the necessary image files in the project.
- If you write the command `docker compose create`, it creates the containers.
- If you write the command `docker compose start`, it starts the containers.

### Port numbers

- WebAPI port number: <b>5178</b> <br/>
- MSSQL Server port number: <b>1433</b>
