#Port and Ship Management Project
This project is a .NET6 web application for managing ports and ships. It includes a controller for managing ships and a repository pattern for data access.

Prerequisites
.NET6 SDK
Visual Studio or another IDE
Getting Started
Clone the repository to your local machine.
Open the solution file in Visual Studio or another IDE.
Run the project and open the application in your web browser.
Usage
The application includes the following endpoints for managing ships:

GET /api/ship - Get all ships.
GET /api/ship/GetShipById/{id} - Get a ship by ID.
POST /api/ship/AddShip - Create a new ship.
PUT /api/ships/UpdateShip - Update an existing ship.
DELETE /api/ship/DeleteShip - Delete a ship by ID.
GET /api/ship/GetClosestPortToShip - Get the nearest ports to a ship and its estimated arrival.
To use these endpoints, make HTTP requests to the appropriate URL with the required parameters and data.

Architecture
The project uses a repository pattern for data access, with a separate repository class for each entity (ship and port). The controller uses these repositories to interact with the data layer.

Contributing
If you'd like to contribute to the project, please fork the repository and create a pull request with your changes. Be sure to follow the project's coding standards and include unit tests for any new functionality.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
If you have any questions or concerns about the project, please contact the project maintainer(s).
