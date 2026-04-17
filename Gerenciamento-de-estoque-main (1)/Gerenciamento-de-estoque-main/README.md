📦 Gerenciamento de Estoque

Sistema desktop desenvolvido em C# (.NET / Windows Forms) para controle de estoque, cadastro de produtos e gestão de movimentações (entrada, saída e consulta).

🚀 Visão Geral

O projeto tem como objetivo fornecer um sistema simples e funcional para gerenciamento de estoque, permitindo o controle eficiente de produtos e suas movimentações dentro de um ambiente comercial.

Ele simula um sistema real de almoxarifado/loja, com foco em organização de dados e operações básicas de inventário.

🧠 Funcionalidades
📋 Cadastro de produtos
✏️ Edição e remoção de registros
📦 Controle de estoque (entrada e saída)
🔍 Consulta de produtos
🧾 Interface gráfica para gerenciamento
💾 Persistência de dados via estrutura local (SQL/arquivos dependendo da implementação)
🏗️ Estrutura do Projeto

O sistema está organizado em módulos principais:

Forms (Interface gráfica)
Telas de cadastro, login e consulta
DAO (Acesso a dados)
Comunicação com banco de dados
Models
Classes de entidade (Produto, Usuário, etc.)
Banco de dados
Estrutura responsável por armazenar produtos e movimentações
Program.cs
Ponto de entrada da aplicação
🛠️ Tecnologias Utilizadas
C#
.NET Framework / .NET Windows Forms
SQL Server / Banco local (dependendo da versão do projeto)
Visual Studio
▶️ Como executar o projeto
Clone o repositório:
git clone https://github.com/restoffkaua08-afk/Gerenciamento-de-estoque.git
Abra o arquivo .sln no Visual Studio
Restaure os pacotes (se necessário)
Configure a string de conexão do banco de dados (se aplicável)
Execute o projeto (F5)
📌 Objetivo Educacional

Este sistema foi desenvolvido com foco em aprendizado prático de:

Programação orientada a objetos (POO)
Estruturação de aplicações desktop
Integração com banco de dados
Organização de código em camadas
Lógica de sistemas comerciais

👨‍💻 Autor

Desenvolvido por Kaua Restoff
Projeto acadêmico / técnico de estudo em desenvolvimento de sistemas.

📈 Melhorias Futuras
Login com níveis de acesso
Relatórios em PDF
Dashboard com gráficos
API para integração web
Versionamento de estoque mais avançado
