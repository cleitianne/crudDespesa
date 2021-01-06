# crudDespesa
Projeto em .Net: Crud de Despesas e Receitas.

## Estrutura
- Padrões como Models e Controllers foram utilizados.
- Bem como padrões de Repository e de Services.

## Documentação da API
O swagger foi utilizado à fim de documentar a API. Para se ter acesso, execute o projeto e acesse (host:porta/swagger/index.html).

## Configuração do Peojeto (Windows)
- Instalar o .net core e o sql server.
- Instalar Visual Studio 2019 OU Visual Studio Code.
- No arquivo *appsetting.json* configurar a string de conexão de acordo com a configuração do SQL SERVER
- Rodar o comando: $dotnet ef database update. Esse comando aplicará as migrations presentes no projeto e o banco de dados será criado.
- Rodar o projeto com o comando $dotnet run.

## Bibliotecas Utilizadas
- Microsoft.EntityFrameworkCore.Design v=3.1.7
- Microsoft.EntityFrameworkCore.SqlServer v=3.1.7
- Microsoft.EntityFrameworkCore.SqlServer.Design v=1.1.6
- Microsoft.EntityFrameworkCore.Tools v=3.1.7
- Swashbuckle.AspNetCore (Swagger) v=5.5.0
