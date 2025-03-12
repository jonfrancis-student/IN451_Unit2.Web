#IN451 Unit 2 Web Application

This web application is built as part of the IN451 Unit 2 project using ASP.NET 9.0 MVC, SQL Server, and C#. It demonstrates how to interact with a SQL Server database using Windows Authentication.
Features

    SQL Server Integration: Connects to a local SQL Server instance (SQLEXPRESS) to interact with the Northwind database.
    Windows Authentication: Uses Windows Authentication for secure database connections, utilizing the current Windows user's credentials for authentication.
    MVC Architecture: Follows the Model-View-Controller (MVC) pattern to separate the application's concerns and improve maintainability.
    Multiple Active Result Sets (MARS): Supports executing multiple queries simultaneously, enhancing performance in certain use cases.

Tech Stack

    ASP.NET 9.0 MVC: For building the web application and handling HTTP requests.
    SQL Server: Used as the relational database to store and retrieve customer data.
    C#: For backend logic and application development.
    Windows Authentication: To authenticate and authorize users based on their Windows credentials.

Setup Instructions
Prerequisites

    SQL Server: Ensure you have a running instance of SQL Server (SQL Server Express or higher) with the Northwind database.
    .NET 9.0 SDK: Make sure you have the .NET 9.0 SDK installed on your machine to build and run the project.
    Visual Studio: Recommended IDE for .NET development.

Getting Started

    Clone the Repository:

git clone https://github.com/yourusername/IN451_Unit2_Web.git

Configure the Connection String:
Update the connection string in the appsettings.json file to point to your SQL Server instance (if necessary):

"ConnectionStrings": {
    "DefaultConnection": "Server=JON\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
}

Build the Application: Open the project in Visual Studio and build the solution.

Run the Application: Press F5 to start the application. It will run in your browser, and you can start interacting with the customer data from the Northwind database.
