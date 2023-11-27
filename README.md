ProjetoLicitacao - Sistema de Gerenciamento de Licitações
Este é um projeto web desenvolvido em C#, ASP.NET MVC, e interação com banco de dados SQL para auxiliar na gestão e acompanhamento de processos de licitação.

Funcionalidades
O projeto fornece as seguintes funcionalidades:

Cadastrar Novas Licitações: Inclui detalhes como número da licitação, descrição, data de abertura e status (aberta, em andamento, fechada).
Listar Licitações: Exibe todas as licitações cadastradas com opções de ordenação e filtragem (por exemplo, por status ou data de abertura).
Atualizar Informações de Licitações: Permite a edição das informações das licitações cadastradas.
Remover Licitações: Exclui licitações do sistema.
Requisitos Técnicos
Front-end: Interface limpa e funcional para interação do usuário.
Back-end: Utilização de C# com ASP.NET e MVC.
Banco de Dados: Implementação de um banco de dados SQL para armazenamento dos dados das licitações.
Código Fonte: Organização e clareza do código.
Documentação: README detalhado com instruções para configuração e execução da aplicação.
Configuração e Execução
Siga as instruções abaixo para configurar e executar o projeto em seu ambiente local:

Requisitos Prévios:

Certifique-se de ter o .NET SDK instalado em seu computador.
Tenha um servidor SQL disponível para a aplicação.
Lembre-se também de configurar corretamente o Entity Framework
Pacote NuGet Microsoft.EntityFrameworkCore v. 6.0.0 e Microsoft.EntityFrameworkCore.SqlServer v. 6.0.0
Configuração do Banco de Dados:

Abra o arquivo appsettings.json e ajuste a string de conexão com o banco de dados.
Execução da Aplicação:

Navegue até o diretório do projeto via terminal ou prompt de comando.
Execute o comando dotnet restore para restaurar as dependências do projeto.
Execute o comando dotnet ef database update para aplicar as migrações e criar o banco de dados.
Execute o comando dotnet run para iniciar a aplicação.
