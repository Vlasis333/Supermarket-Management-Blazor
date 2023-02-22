# Supermarket Management - .NET 6.0

"Supermarket Management" is a software application that helps supermarkets and grocery stores manage their daily operations. This specific project, which is written in C# and uses the ASP.NET Core Blazor framework, the Entity framework (EF Core) for data access, and SQL Server for storing data, as well as Identity for authentication and authorization. The application may include features such as inventory management, point-of-sale, customer management, and reporting. It will help Supermarket to manage the inventory, sales, purchase, customer details and other day to day operations with ease.

Capabilities include:
 - Viewing, adding, editing, and deleting categories
 - Viewing, adding, editing, and deleting products
 - Cashiers' console for listing sold items and transactions report
 - Printing reports
 - Connecting to SQL using EF Core
 - Using ASP.NET Core Identity for Authentication and Authorization.

## Instructions
1. Clone repository
2. Right click on solution and select 'Restore NuGet Packages'
3. On Plugins.DataStore.SQL project run this command at Package Manager Console
    - 'Update-Database'
    - You can change the location of the database from the appsettings.json file.
    - Default: localdb for both application and authentication table (2 databases)
4. Run blazor application
