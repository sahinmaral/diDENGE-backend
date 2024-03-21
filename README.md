# diDENGE-Backend

## Türkçe [TR]

Projeyi çalıştırmak için herhangi bir SDK, framework kurmanıza gerek yoktur.
Gerekenler :

- Docker

### Yapılacaklar (v1)

- Projenin dizininde <b>.env</b> adlı dosya oluşturun, içerisine `version=1.0` yazın ve kaydedin
- Projenin dizininde terminali açın.
- `docker compose build` komutunu yazarsak projedeki gerekli image dosyalarını yükler
- `docker compose create` komutunu yazarsak container ları oluşturur
- `docker compose start` komutunu yazarsak container ları çalıştırır

### Yapılacaklar (v2)

- Projenin dizininde <b>.env</b> adlı dosya oluşturun, içerisine `version=1.0` yazın ve kaydedin
- Projenin dizininde terminali açın.
- `docker compose up -d` komutunu yazarsak image dosyalarını yükler, sonrasında container ları oluşturur ve sonrasında ise çalıştırır

### Port numaraları

WebAPI port numarası : <b>5178</b> <br/>
MSSQL Server port numarası : <b>1433</b>

## English [EN]

To run the project, you don't need to install any SDK or framework.

Requirements:

- Docker

### Steps to Perform (v1)

- Create a file named <b>.env</b> in the project directory, write <b>version=1.0</b> inside it, and save.
- Open the terminal in the project directory.
- If you write the command `docker compose build`, it installs the necessary image files in the project.
- If you write the command `docker compose create`, it creates the containers.
- If you write the command `docker compose start`, it starts the containers.

### Steps to Perform (v2)

- Create a file named <b>.env</b> in the project directory, write <b>version=1.0</b> inside it, and save.
- Open the terminal in the project directory.
- If you write the command `docker compose up -d`, it installs the image files, then creates the containers, and finally starts them.

### Port numbers

- WebAPI port number: <b>5178</b> <br/>
- MSSQL Server port number: <b>1433</b>
