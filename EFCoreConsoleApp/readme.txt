# Migration Command
- dotnet ef dbcontext scaffold "Server=localhost;Database=EFCore;User Id=sa;Password=Ericsson123" Microsoft.EntityFrameworkCore.SqlServer --context-dir DataScaffold --output-dir ModelsScffold
- dotnet ef migrations add InitialCreate
- dotnet ef database update --context EFCoreConsoleApp.Data.ContosePizzaContext