**Eau Claire's Salon**

#### By **Nathan Conn**

#### This program was designed specifically for Eau Claire's Salon for the purpose of keeping a record of stylists and clients.


## Technologies Used

* C#
* NET 5.0
* MVC
* MS Testing



## Description

Eau Claire needed an application to help her store her stylists and their clients, so this is meant to be used by the managerial staff only. Clients, if they become regular, can be added to the database and assigned to the stylist they regularly see. Stylists can be added to the database as well, as these two are connected in the same database.

## Setup/Installation Requirements

* Clone repository.
* In the command line, run "dotnet restore" in the Salon directory.
* In the command line, run "dotnet build" in  the Salon and directory.
* In the command line, run "dotnet run" while in the Salon directory to run the program.
* You will need to create an appsettings.json file in order to use and store information into the database that is attached. Use the code below and replace the necessary fields with your information:

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=DBNAMEHERE;uid=root;pwd=PASSWORDHERE;"
    }
}


## Known Bugs

*My foreach loop will not print multiple vendors to a line, and currently only will log one at a time and not display the name, however all other aspects of the page run and function when accessed from the dev tools console in Google Chrome. 

## Contact Me

Let us know if you run into any issues or have questions, ideas, or concerns:
nconn34@gmail.com

## License

Copyright (c) 3/12/2022 Nathan Conn.