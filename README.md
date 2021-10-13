# TruckManager
[API]
-Make sure you have an updated version of VS2019 to run the API
-When oppening the solution, make sure TruckManager.API is set as startup project
-Run in PackageManager (TruckManager.API) the command Update-Database (make sure to update the connection string on appsettings.json with your server name before proceeding)

[FRONT-END]
-Make sure you have node.js installed
-Open the project with VSCode and run npm install (may take some time depending on your internet speed)
-Run ng s command inside VC Code terminal (make sure your file path is correct)

Nuget packeged required:
  -TruckManager.API
    -Autofac(6.3.0)
    -Autofac.Extensions.DependencyInjection(7.1.0)
    -Microsoft.EntityFrameworkCore.Design(5.0.10)
    -Microsoft.EntityFrameworkCore.SqlServer(5.0.10)
    -Swashbuckle.AspNetCore(6.2.2)
    
  -TruckManager.Application
    -AutoMapper(10.1.1)
    
  -TruckManager.Infrastucture
    -Autofac(6.3.0)
    -Microsoft.EntityFrameworkCore.SqlServer(5.0.10)
    -Microsoft.EntityFrameworkCore.Tools(5.0.10)
    
  -TruckManager.Tests
    -AutoFixture(4.17.0)
    -AutoMapper.Extensions.Microsoft.DependencyInjection(8.1.1)
    -Microsoft.NET.Test.Sdk(16.11.0)
    -Moq(4.16.1)
    -NUnit(3.13.2)
    -NUnit3TestAdapter(4.0.0)
