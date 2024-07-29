
# Project Overview

This project serves as an introductory exploration into the basics of containerization using Docker. It features the containerization of an application and a SQL server, aimed at demonstrating the essential concepts and workflows of Docker.

## Requirements

- Docker
- .NET Core SDK
- Visual Studio (with Docker integration enabled)
- SQL Server Management Studio (optional, for database management)

## Project Goals

The primary goal of this project was to gain a foundational understanding of Docker containerization. The tasks included setting up a development environment using containers, managing a SQL server within a Docker container, and integrating it with an application developed in .NET.

## Encountered Issues

During the development process, several issues were encountered, particularly with the SQL server container setup. For example, one significant issue was related to the SQL server image from Microsoft, as detailed in [issue #301 on the mssql-docker GitHub repository](https://github.com/Microsoft/mssql-docker/issues/301). This issue involved complications with the SQL server image, which required troubleshooting permissions and storage configurations.

## Screenshots and Commands

Below are some key commands used in the project, including the use of Entity Framework scaffolding:

```bash
# Scaffold Entity Framework commands
dotnet ef dbcontext scaffold "Server=localhost;Database=MyDatabase;User=sa;Password=MyPassword;" Microsoft.EntityFrameworkCore.SqlServer -o Models
```

### Screenshots

(Screenshots of the application and SQL server setup would be inserted here, demonstrating the working environment and any relevant outputs from the Docker containers.)

## SQL Container Setup Instructions

To run the SQL server container, follow these steps:

```bash
# Pull the latest SQL server image
docker pull mcr.microsoft.com/mssql/server:2019-latest

# Run the SQL server container
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrongPassword1" -p 1433:1433 --name sql1 -h sql1 -d mcr.microsoft.com/mssql/server:2019-latest
```

Replace `YourStrongPassword1` with a strong password of your choosing.

## Database Creation

After setting up the SQL server container, create your database using the following SQL command:

```sql
CREATE DATABASE MyDatabase;
```

This command can be executed through a SQL client connected to your Docker-hosted SQL server.

## Running the Application

Visual Studio automates the process of running the Dockerized application. Simply open the solution in Visual Studio, and it will manage the Docker containers for the application automatically.
