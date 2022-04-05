# _StarTrekAPI_

#### By _**Marisa Edgar, Zachary Green, Isaac Overstreet, Chase Stokes, Mikah Mathews**_

#### _An API with Star Trek Timeline info, using Databases, C# and ASP.NET Core API technology_

## Technologies Used

* _`HTML`_
* _`CSS`_
* _`Bootstrap`_
* _`CSHTML`_
* _`MySQL`_
* _`Postman`_
* _`C#`_
* _`Entity Framework`_
* _`ASP.NET Core`_

## Description


_A project for Epicodus using C# utilizing a database. The application is a Star Trek Timeline with dates and info on each date. Allows the user to create new listings for Characters or TrekEvents. API has full Crud functionality for Get, Put, Post and Delete_

## API Endpoints
<hr>
<strong>GET</strong>
<hr>
 You can get data back from your api via the localhost by using several different parameters. This api defaults with the standard index which would be `http://localhost:5000/api/TrekEvents`. This will pull up all results from the database.

 #
 However you can also search for specific results by adding a query or `?` after /Park and one of the class parameters such as: `http://localhost:5000/api/TrekEvents?Date="2063"`.


#
<hr>
<strong>PUT</strong>
<hr>
With this feature you can edit values inside of your database. This can be easily seen inside of Postman and is useful for Modifying a Typo or changing a field without having to delete the entry and create a new one. 

#
<hr>
<strong>POST</strong>
<hr>
This feature will let you create new content for your database. This can be easily done within `Postman` and the results can be seen inside on your Parks table in `MySQL Workbench`, `MySQL Server` or `Postman` with Postman's `GET`.

#
In `Postman`, change the `GET` drop down to `POST`, then in the first window below where your localhost address goes select the parameter for `Body` and make sure the drop down window is changed to `Json`. You will be able to create brand new entries in this window. Note that any new entry must contain all the parameters stated in the Park class within the Models folder.

#
<hr>
<strong>DELETE</strong>
<hr>
This feature will let you delete an entry or the entire database if you would like. Those result will vary on the search parameters.

#


## Setup/Installation Requirements

<strong><em>Requirements for Running the Project</em></strong>
#

### Programs You Will Need
#

1. MySQL Server - visit https://www.mysql.com/downloads/ and download mySQL Server, follow the installation instructions for your operating system.

2. MySQL Workbench - visit https://www.mysql.com/products/workbench/ and download mySQL Workbench, follow the installation instructions for your operating system.

3. Postman - visit https://www.postman.com/downloads/ and download Postman, follow the installation instructions for your operating system.

4. VSCode - visit https://code.visualstudio.com/ and download VSCode, follow the installation instructions for your operating system.

Developer Note -- <em>You do not need to type in `$` into the terminal, the terminal starts with `$` on GitBash and `%` on Bash.</em>

* Visit https://github.com/marisa-edgar/StarTrekAPI.git
* Clone this repository to your desktop.
* Navigate to the top level directory in your terminal.
* Run "$ `touch appsettings.json`"
* Run "$ `code .`" to open the project in VS Code. If you do not have VS Code please visit their website: https://code.visualstudio.com/
* Add in this code to the `appsettings.json` file inside `VS Code`:

{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[YOUR_PASSWORD_HERE];"
  }
}

* Create a gitignore file. Run "$ `touch .gitignore`" on the top level of the project.
* Inside of `VS Code` type in `appsettings.json` into the gitignore file. This will keep your password safe.
* Change the password to be whatever password you will want to use with SQL.


Developer Note -- <em>You do not need the square brackets around the password field in the appsettings.json file, they are included only to demonstrate where the password needs to be.</em>

* Run "$ `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`"
* Run "$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`"
* Run "$ `dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0`"
* Run "$ `dotnet restore`" to restore the bin and obj folders.
* Run "$ `dotnet build`" to build the project.
* Run "$ `dotnet ef migrations add Initial`"
* Run "$ `dotnet ef database update`"
* Run "$ `dotnet run`" to launch a LocalHost.
* Open Postman. The front page should have a section with a button to the left that says `GET` by default. This is where you will put your `localhost` address in.
* Click `SEND` to get a look at all of the data inside of the database of the API, by default there is seeded data in the `StarTrekContext.cs` file, but you can add your own data with the `POST` method.



## Known Bugs

* _No known bugs_

## License

_Any questions or concerns please email me at marisaedgar1212@gmail.com_

License under [MIT License]_(LICENSE)_

Copyright (c) _2022_

_[Marisa Edgar](https://github.com/marisa-edgar), 
 [Zachary Green](https://github.com/Ultra-Zactimus), 
 [Isaac Overstreet](https://github.com/mrunderoad), 
 [Chase Stokes](https://github.com/Chase-Stokes), 
 [Mikah Mathews](https://github.com/mikah-mathews)_
 
