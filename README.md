# IN451 Unit 2 Web Application

This web application is built as part of the IN451 Unit 2 project using ASP.NET 9.0 MVC, SQL Server, and C#. It demonstrates how to implement a database schema and create an n-tier application to access the database.
## Features
- **SQL Server Integration:** Connects to a local SQL Server instance (SQLEXPRESS) to interact with the Northwind database.
- **Windows Authentication:** Uses Windows Authentication for secure database connections, utilizing the current Windows user's credentials for authentication.
- **MVC Architecture:** Follows the Model-View-Controller (MVC) pattern to separate the application's concerns and improve maintainability.

## Tech Stack

- **ASP.NET 9.0 MVC:** For building the web application and handling HTTP requests.
- **SQL Server:** Used as the relational database to store and retrieve customer data.
- **C#:** For backend logic and application development.
- **Windows Authentication:** To authenticate and authorize users based on their Windows credentials.

## Installation
### Prerequisites

- **SQL Server:** Ensure you have a running instance of SQL Server (SQL Server Express or higher) with the Northwind database.
- **.NET 9.0 SDK:** Make sure you have the .NET 9.0 SDK installed on your machine to build and run the project.
- **Visual Studio:** Recommended IDE for .NET development.

### Cloning the Repository
To clone the repository, run the following command:
```bash
git clone git clone https://github.com/jonfrancis-student/IN451_Unit2_Web.git
```


### Configure the Connection String:
Update the connection string in the appsettings.json file to point to your SQL Server instance (if necessary):
```bash
"ConnectionStrings": {
    "DefaultConnection": "Server=YourServerName;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
}
```
