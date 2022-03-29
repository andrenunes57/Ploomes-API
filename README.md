# Ploomes 

Serviço para cadastrar e ler dados de colaboradores

### Para rodar localmente é necessário ter o Visual Studio ou VSCode e SQL Server.

Faça a conexão com algum banco de dados local, alterando o endereço da "DefaultConnection" para sua conexão local no arquivo appsettings.json:

``
{
  "ConnectionStrings": {
    "DefaultConnection": "Server= Insira aqui o nome do enderço do seu servidor local;Database=Rocky;Trusted_Connection=True;MultipleActiveResultSets=True"
  }
``

### Tecnologias utilizadas:

* Dotnet 5.0
* SQL Server
* EntityFrameworkCore
* SwaggerUI (https://endereco-da-api/swagger/index.html)