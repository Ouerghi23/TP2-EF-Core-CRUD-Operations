# 🎬 TP2 : EF Core & CRUD Operations

## 📌 Objectifs

- Créer des entités : `Movie`, `Genre`, et `Customer`
- Utiliser EF Core pour générer une base de données via l'approche Code First
- Réaliser des opérations CRUD avec des contrôleurs et vues Razor Pages
- Implémenter une relation **One-to-Many** entre `Genre` et `Movie`

---

## 🛠️ Technologies & Packages utilisés

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core 8
- SQL Server LocalDB
- Razor Pages
- LINQ

### 📦 Packages NuGet à installer

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.0
