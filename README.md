# Pie shop
ASP.NET Core 2.0 MVC Application with Visual Studio 2017

### What does this application do?
This application was created by following the following course for learning purposes. 
https://www.pluralsight.com/courses/building-first-aspdotnet-core-2-mvc-application. The project allows users to check pies available in the shop, view details and share feedback by login in.

### Framework/Paradigms used
1. .NET Core 2.1
2. Entity Framework Code First
3. Javascript, jQuery
4. Html, CSS, Bootstrap

### To run the application, follow the steps

1. Rebuild your project 
2. Go to Tools -> NuGet Package Manager -> Package Manager Console
3. run the command **PM> update-database** 

### To make sure that the database was created

1. Go to View, click *SQL Server Object Explorer*
2. Under *SQL Server*, find your local database **PieShop**
3. Check if the tables are created