# .NET CRUD com Entity Framework e Swagger usando SQL Server

Este documento tem o objetivo de fornecer informações sobre como criar uma aplicação CRUD em .NET utilizando Entity Framework para a camada de acesso a dados, Swagger consumo de API e SQL Server como banco de dados.

## Tecnologias Utilizadas:

- **.NET Framework ou .NET Core**: Plataforma de desenvolvimento para criação de aplicativos Windows, Web e serviços.
  
- **Entity Framework**: ORM (Object-Relational Mapping) que simplifica o acesso a dados em aplicativos .NET, permitindo que os desenvolvedores trabalhem com objetos específicos do domínio, sem precisar escrever SQL.

- **Swagger**: Ele permite que os desenvolvedores produzam e consumam APIs de maneira eficiente.

- **SQL Server**: Sistema de gerenciamento de banco de dados relacional (RDBMS) desenvolvido pela Microsoft.

## Passos para Criar um CRUD com Entity Framework e Swagger:

1. **Configuração do Projeto**:
   - Crie um projeto .NET (ASP.NET Core ou ASP.NET Framework) em sua IDE preferida.
   - Instale os pacotes do Entity Framework e do Swagger usando o NuGet Package Manager.

2. **Modelagem de Dados**:
   - Defina seus modelos de dados que serão mapeados para o banco de dados usando o Entity Framework.

3. **Configuração do Entity Framework**:
   - Configure o Entity Framework para se conectar ao seu banco de dados SQL Server.
   - Mapeie os modelos de dados para as tabelas do banco de dados.

4. **Criação das Operações CRUD**:
   - Implemente métodos para criar, ler, atualizar e excluir (CRUD) dados usando o Entity Framework.
  
6. **Teste e Validação**:
   - Teste cada operação CRUD para garantir que elas estejam funcionando corretamente.
