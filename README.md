# Sistema de Gerenciamento de Estoque

<div align="center">

<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&height=220&color=0:0F172A,45:1E3A5F,100:2563EB&text=GERENCIAMENTO%20DE%20ESTOQUE&fontColor=FFFFFF&fontSize=38&fontAlignY=38&animation=fadeIn&desc=APLICA%C3%87%C3%83O%20DESKTOP%20EM%20C%23%20E%20MYSQL&descAlignY=59&descSize=15" alt="Gerenciamento de Estoque"/>

<img src="https://readme-typing-svg.demolab.com?font=JetBrains+Mono&weight=600&size=20&duration=2800&pause=900&color=60A5FA&center=true&vCenter=true&width=900&lines=C%23+%E2%80%A2+.NET+%E2%80%A2+Windows+Forms;Cadastro%2C+consulta+e+controle+de+produtos;Persist%C3%AAncia+com+MySQL;Programa%C3%A7%C3%A3o+orientada+a+objetos" alt="Stack do projeto"/>

<br>

### Aplicação desktop para controle de produtos e operações de estoque.

<br>

![Status](https://img.shields.io/badge/STATUS-ACADÊMICO-2563EB?style=for-the-badge&labelColor=0F172A)
![Platform](https://img.shields.io/badge/PLATAFORMA-WINDOWS-60A5FA?style=for-the-badge&labelColor=0F172A)
![Architecture](https://img.shields.io/badge/ARQUITETURA-DESKTOP-93C5FD?style=for-the-badge&labelColor=0F172A)

</div>

<br>

# `> PROJECT.OVERVIEW`

O **Sistema de Gerenciamento de Estoque** é uma aplicação desktop desenvolvida para praticar a construção de sistemas comerciais com interface gráfica, regras de negócio e persistência relacional.

O sistema oferece telas específicas para login, cadastro, consulta, atualização e remoção de produtos. O código separa entidades, acesso a dados, serviços e formulários, aproximando o projeto de uma aplicação organizada em camadas.

<br>

# `> CORE.TECH_STACK`

<div align="center">

<img src="https://skillicons.dev/icons?i=cs,dotnet,mysql,visualstudio,git,github&theme=dark" alt="C Sharp, .NET, MySQL, Visual Studio, Git e GitHub"/>

</div>

| Tecnologia | Utilização |
|---|---|
| C# | Regras, eventos e lógica da aplicação |
| .NET 10 | Plataforma de execução |
| Windows Forms | Interface gráfica desktop |
| MySQL | Persistência dos produtos |
| MySql.Data | Comunicação da aplicação com o banco |
| Visual Studio | Desenvolvimento e execução |

<br>

# `> SYSTEM.FEATURES`

- autenticação por tela de login;
- cadastro de produtos;
- consulta do estoque;
- atualização de registros;
- remoção de produtos;
- organização das operações em formulários;
- acesso ao banco por uma camada DAO;
- representação de produtos em uma classe de modelo.

<br>

# `> SYSTEM.ARCHITECTURE`

```text
Usuário
   │
   ▼
Windows Forms
   │
   ▼
Regras da aplicação
   │
   ▼
ProdutoDAO
   │
   ▼
MySQL
```

A interface recebe as ações do usuário, os modelos representam os dados e o DAO centraliza as operações relacionadas à persistência.

<br>

# `> PROJECT.STRUCTURE`

```text
Gerenciamento-de-estoque-main/
├── DAO/
│   └── ProdutoDAO.cs
├── Models/
│   ├── Database.cs
│   └── Produto.cs
├── Services/
│   └── Regras de Negócios.txt
├── src/Gerenciamentodeestoque/forms/
│   ├── FrmLogin.cs
│   ├── FrmMenu.cs
│   ├── FrmCadastrar.cs
│   ├── FrmConsultar.cs
│   ├── FrmAtualizar.cs
│   └── FrmRemover.cs
├── Program.cs
└── estoque_s_a.csproj
```

> A estrutura atual ainda contém uma pasta intermediária herdada de uma importação anterior. Sua simplificação está prevista sem alterar o código funcional.

<br>

# `> GETTING.STARTED`

## Pré-requisitos

- Windows;
- Visual Studio com suporte a desenvolvimento desktop .NET;
- SDK do .NET 10;
- servidor MySQL;
- Git.

## Instalação

```bash
git clone https://github.com/restoffkaua08-afk/Gerenciamento-de-estoque.git
cd Gerenciamento-de-estoque
```

Abra o arquivo de solução ou projeto localizado na pasta interna pelo Visual Studio, restaure os pacotes NuGet e configure o acesso ao MySQL conforme o ambiente local.

## Execução

- selecione o projeto `estoque_s_a`;
- restaure a dependência `MySql.Data`;
- confirme a configuração do banco;
- execute pelo Visual Studio.

<br>

# `> QUALITY.ASSURANCE`

Para validar a compilação:

```bash
dotnet restore
dotnet build
```

Os fluxos de cadastro, consulta, atualização, remoção e login também devem ser verificados manualmente na interface.

<br>

# `> SECURITY`

- não publique credenciais do MySQL;
- mantenha configurações locais fora do controle de versão;
- valide dados antes de enviá-los ao banco;
- utilize consultas parametrizadas;
- não versione arquivos produzidos por `bin/`, `obj/` ou pelo Visual Studio.

<br>

# `> PROJECT.ROADMAP`

- [ ] simplificar a estrutura de diretórios;
- [ ] mover configurações do banco para variáveis locais;
- [ ] adicionar validações de formulário;
- [ ] automatizar testes das regras de negócio;
- [ ] adicionar capturas das principais telas;
- [ ] criar um instalador ou pacote de distribuição.

<br>

# `> ENGINEERING.PRINCIPLES`

> **Um estoque confiável depende de dados consistentes e operações previsíveis.**

<br>

# `> PROJECT.STATUS`

## Projeto acadêmico disponível para evolução

<br>

# `> DEVELOPER`

## Kauã Restoff

### Desenvolvedor de Software

[![GitHub](https://img.shields.io/badge/GitHub-restoffkaua08--afk-181717?style=for-the-badge&logo=github)](https://github.com/restoffkaua08-afk)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Kauã%20Restoff-0A66C2?style=for-the-badge&logo=linkedin)](https://www.linkedin.com/in/kau%C3%A3-restoff-2821163a0)

<div align="center">

## `BUILD • ORGANIZE • CONTROL`

<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&height=120&section=footer&color=0:0F172A,45:1E3A5F,100:2563EB" alt="Rodapé"/>

</div>
