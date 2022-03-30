# Ploomes Employee API

Esse projeto é uma API que cadastra e consulta dados de funcionários em um banco de dados.  

## Como funciona o Serviço
A API é baseada no Swagger que permite realizar as chamadas dos métodos, além de deixar registrado dentro do próprio Swagger quais são os métodos, os resultados e os parâmetros esperados

Os métodos da API são: 

 * **GET /api/Employees** `Busca a lista dos funcionários cadastrados`
 * **POST /api/Employees** `Cadastra um funcionário` 
 * **GET /api/Employees/{id}** `Busca um funcionário pelo Id (identificador único de cadastro)`

## Começando
Escolha um dos 2 ambientes abaixo para rodar o projeto:

### 1. Ambiente de Produção (live)

Para utilizar o serviço na nuvem, acesse o link abaixo:

https://ploomesapi.azurewebsites.net/swagger/index.html
(O serviço pode levar alguns segundos para carregar)


### 2. Ambiente de Desenvolvimento (localhost)

#### Tecnologias 
Garante que você possui os seguintes pré-requisitos instalados

  * .NET
[SDK .NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
---

  * Banco de Dados
[SQL Server Management Studio (SSMS)](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15#download-ssms) 
OU 
[Azure Data Studio](https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15#download-azure-data-studio) além do [Docker Desktop](https://www.docker.com/products/docker-desktop/) junto com a [imagem do Microsoft SQL Server](https://hub.docker.com/_/microsoft-mssql-server)
---

  * IDE/Editor de código
[Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)
OU
[Visual Studio Code](https://code.visualstudio.com/download)
OU
[JetBrains Rider](https://www.jetbrains.com/pt-br/rider/download/#section=windows)
---

#### Configurações / Build

  * Faça o clone do projeto localmente: `git clone https://github.com/andrenunes57/Ploomes-API.git`

  * Na pasta raiz do projeto, no arquivo **appsettings.json**, altere o valor da chave `"ServerConnection"` para a string de conexão do seu banco de dados local

  * Garanta que os pacotes NuGet estão restaurados:
Na pasta raiz do projeto `Ploomes-API/`, rode o comando `dotnet restore`

  * Para criar a base de dados local, abra o Console do Gerenciador de Pacotes e rode o comando `update-database`
Se a abordagem acima não funcionar, instale o **ef tool**, rode `dotnet tool install --global dotnet-ef` e da pasta raiz, navegue para a pasta do projeto `Ploomes-API/PloomesAPI/` e rode o comando `dotnet ef database update`

  * Verifique se o banco dados com o nome escolhido na string de conexão é listado no software de banco de dados (aparecerá "Ploomes" caso não tenha alterado o nome)  

  * Rode a aplicação.

  * Deverá abrir o Swagger no localhost, num link com o seguinte formato: https://localhost:xxxxx/swagger/index.html



