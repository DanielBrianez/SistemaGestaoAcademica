# 📝 Sistema de Gestão Academica  

![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet?style=flat-square&logo=dotnet)  
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow?style=flat-square)  
![Banco de Dados](https://img.shields.io/badge/SQL-Server-red?style=flat-square&logo=microsoftsqlserver)  
![Licença](https://img.shields.io/badge/license-MIT-green?style=flat-square)  

Projeto desenvolvido em **C# com .NET 8** paraGestão Academica , integrando com **SQL Server** como banco de dados.  

## 🚀 Tecnologias Utilizadas  
- 💻 **C#** (.NET 8)  
- 🗃 **Entity Framework Core** (ORM para acesso ao banco de dados)  
- 🛢 **SQL Server** (banco de dados relacional)  

## 🔧 Configuração e Execução  

### 1️⃣ Pré-requisitos  
- [📦 .NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)  
- [🛢 SQL Server](https://www.microsoft.com/sql-server)  
- [🖥 Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)  

### 2️⃣ Clonar o Repositório  
```bash
git clone https://github.com/seu-usuario/nome-do-projeto.git
cd nome-do-projeto
````

### 3️⃣ Configurar a String de Conexão

No arquivo `appsettings.json`, ajuste a string de conexão para o seu SQL Server:

```jsonc
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=CadastroClientesDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4️⃣ Aplicar Migrações

```bash
dotnet ef database update
```

### 5️⃣ Executar o Projeto

```bash
dotnet run
```

A aplicação estará disponível em **[https://localhost:5001](https://localhost:5001)** (ou na porta configurada).

## 📌 Funcionalidades

✅ **Cadastro de alunos, unidades e cursos**
✅ **Listagem de alunos, unidades e cursos**
✅ **Atualização e exclusão de registros**
✅ **Persistência em banco de dados**

## 📄 Licença

Este projeto é open-source, sob a licença [MIT](LICENSE).


