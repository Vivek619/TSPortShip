# TSPortShip
## PortShip Management using .NET 6
This project is a .NET6 web application for managing ports and ships. It includes a controller for managing ships and a repository pattern for data access.

## Prerequisites
* .NET6 SDK
* Visual Studio or another IDE

## Getting Started
1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio or another IDE.
3. Run the project and open the application in your web browser.

## Usage
The application includes the following endpoints for managing ships:

#### GET /api/ships - Get all ships.
#### GET /api/ships/{id} - Get a ship by ID.
#### POST /api/ships - Create a new ship.
#### PUT /api/ships/{id} - Update an existing ship.
#### DELETE /api/ships/{id} - Delete a ship by ID.
#### GET /api/ports/nearest - Get the nearest ports to a ship and its estimated arrival.
To use these endpoints, make HTTP requests to the appropriate URL with the required parameters and data.

## Architecture
The project uses a repository pattern for data access, with a separate repository class for each entity (ship and port). The controller uses these repositories to interact with the data layer.

## Contributing
If you'd like to contribute to the project, please fork the repository and create a pull request with your changes. Be sure to follow the project's coding standards and include unit tests for any new functionality.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Contact
If you have any questions or concerns about the project, please contact the project maintainer(s).
