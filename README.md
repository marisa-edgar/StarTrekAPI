# _TreatFlavor.Solution_

#### By _**Marisa Edgar**_

#### _An application to track Flavors and Treats at Pierres Bakery, using many-to-many relationships with C# and .NET_

## Technologies Used

* _HTML_
* _CSS_
* _Bootstrap_
* _CSHTML_
* _MySQL_
* _C#_
* _Entity Framework_
* _.NET_

## Description


_A project for Epicodus using C# utilizing many-to-many relationships. The application allows the user to create Flavors and assign them to the Treats or create Treats and assign them to Flavors, or to create a Treat or Flavor without assigning them at all_


## Setup/Installation Requirements

* _Requires VSCode and MySQL_
* _clone the repository to your desktop and by entering *git clone https://github.com/marisa-edgar/TreatFlavor.Solution.git*_
* _Navigate to the TreatFlavor production file_
* _enter *touch appsettings.json* _
* _within the appsettings.json add this code_
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=DATABASE HERE;uid=USERNAME;pwd=PASSWORD;"
  }
}
* _update code with your your MySQL username and password_
* _Within the the Factory directory run *dotnet ef database update* in your terminal_ 
* _Run *dotnet restore* to restore the obj and bin files._
* _Run *dotnet build* to build the project._
* _Run *dotnet run* to run the page._
* _In your browser go to localhost:5000_


_A project for Epicodus using C# utilizing many-to-many relationships. The application allows the user to create Flavors and assign them to the Treats or create Treats and assign them to Flavors, or to create a Treat or Flavor without assigning them at all_

## Known Bugs

* _No known bugs_

## License

_Any questions or concerns please email me at marisaedgar!@@gmail.com_

License under [MIT License]_(LICENSE)_

Copyright (c) _2022_ _Marisa Edgar_