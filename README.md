# HairSalon
MVC application connected to a MySQL database using EF core.

 #### By Estevan Lopez

## Technologies Used
* Github
* C#
* ASP.NET Core MVC framework
* VS Code
* MySQL
* EF Core


## Description
The application utilizes the .NET Core MVC framework to create a system for monitoring Stylists who handle different Clients. It features two interconnected classes to display and record the data effectively as well as a connected database using EF core to communicate with MySQL


### Set Up and Run Project
MySQL database instructions: 
1. In the Navigator > Administration window, select Data Import/Restore.
2. In Import Options select Import from Self-Contained File.
3. Navigate to the file estevan_lopez_dump.sql
4. Under Default Schema to be Imported To, select the New button.
5. Enter the name of your database - Click Ok.

Git instructions:
1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "HairSalon".
3. Within the production directory "HairSalon", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=[yourid];pwd=[yourpw];"
  }
}
```

5. Within the production directory "HairSalon", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. 

## Known Bugs

* If it crashes clone the repository and start again
* email the host if there are re-occuring issues or any questions

## licensing info 
*Copyright (c) 10/5/2023 Estevan Lopez
*MIT license 