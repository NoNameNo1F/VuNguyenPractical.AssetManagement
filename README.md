# VuNguyenPractical.AssetManagement

A self-practical project built with Clean Modulith architecture, Domain-Driven Design (DDD), Event-Driven principles, and ADO.NET (via Entity Framework Core). This project is a clone inspired by a Nashtech asset management system, designed for managing assets, assignments, returning requests, staff, and reports. It is intended for personal learning and experimentation, with licensing to prevent unauthorized use in proprietary projects.

## Table of Contents
- [Project Overview](#project-overview)
- [Features](#features)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [License](#license)
- [Contributing](#contributing)
- [Contact](#contact)

## Project Overview
**VuNguyenPractical.AssetManagement** is a self-practical project developed to deepen understanding of modern software architecture and backend development. It replicates an asset management system for tracking organizational assets, managing assignments, handling return requests, and maintaining staff records. The project emphasizes Clean Modulith architecture, combining modular design with DDD principles, and uses an event-driven approach for scalability and maintainability. It is built for personal use and learning, with restrictions to prevent others from using it as their own project.

## Features
- **Asset Management**: Create, update, delete, and retrieve assets with details like asset code, name, specification, state, and category.
- **Assignment Management**: Assign assets to staff, update assignments, and track assignment history.
- **Returning Requests**: Manage requests for returning assigned assets, including status tracking.
- **User Management**: Administer staff accounts, including creation, updates, and disabling, with role-based access (Admin and Staff).
- **Authentication & Authorization**: Secure JWT-based authentication with refresh tokens and role-based authorization.
- **Pagination and Filtering**: Efficiently query assets, assignments, and users with sorting, searching, and filtering capabilities.
- **Location-Based Access**: Restrict operations to users within the same location (e.g., HCM, HN, DN).
- **Error Handling**: Robust global exception handling with detailed error responses.
- **Swagger Documentation**: Interactive API documentation for development and testing.

## Architecture
The project follows a **Clean Modulith** architecture, blending modular monolith design with DDD principles. Key architectural components include:

- **Domain-Driven Design (DDD)**:
  - **Core Layer**: Contains domain entities (`Asset`, `Assignment`, `User`, `Category`, `ReturningRequest`), enums (`AssetStatus`, `ERole`, `ELocation`), and interfaces for services and repositories.
  - **Application Layer**: Handles business logic, DTOs, mappers, and validators using FluentValidation.
  - **Infrastructure Layer**: Implements data access (Entity Framework Core with SQL Server), repositories, and external configurations.

- **Event-Driven Design**:
  - While not fully event-sourced, the system uses an event-driven approach for certain operations (e.g., updating asset states or triggering notifications), facilitated by dependency injection and service layers.

- **Clean Modulith**:
  - The solution is organized into modules (`AssetManagement.Api`, `AssetManagement.Core`, `AssetManagement.Application`, `AssetManagement.Infrastructure`), each with clear responsibilities.
  - Modules are loosely coupled but deployed as a single application, balancing modularity with simplicity.

- **Data Access**:
  - Uses Entity Framework Core for ORM, with a SQL Server database (`AssetManagement`).
  - Configured with migrations and entity type configurations for robust data modeling.

## Technologies
- **.NET 9.0**: Backend framework for building the API.
- **Entity Framework Core 9.0.5**: ORM for database operations.
- **Masstransit**: Event Publishing that's support Queue, Outbox, and more).
- **Quart**: Background Jobs.
- **SQL Server**: Database for storing assets, users, assignments, and requests.
- **ASP.NET Core Identity**: User authentication and role management.
- **Identity Provider**: Used external provider for managing token(Keycloak, Identity Server 4, or Duende).
- **JWT Authentication**: Secure token-based authentication with refresh tokens.
- **FluentValidation 11.11.0**: Validation for API requests.
- **Swashbuckle.AspNetCore 8.1.1**: Swagger for API documentation.
- **MediatR**: Sending Commands, Queries, custom Pipe and Pump and so on.
- **Microsoft.Extensions.DependencyInjection**: Dependency injection for services and repositories.
- **CORS**: Configured for frontend integration.

## Setup and Installation
### Prerequisites
- .NET 9.0 SDK
- SQL Server (local or azure sql cloud)
- JetBrains Rider 2025.1
- Git (for cloning the repository)

### Steps
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/NoNameNo1F/VuNguyenPractical.AssetManagement.git
   cd VuNguyenPractical.AssetManagement
   ```

2. **Configure Database**:
   - Update the connection string in `appsettings.Development.json`:
     ```json
     "ConnectionStringsOption": {
       "Default": "Data Source=YourServer;Initial Catalog=AssetManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
     },
     ...
     ```
   - Run migrations to set up the database:
     ```bash
     cd ./Hosts/AssetManagement.Migrator
     dotnet watch run
     # or
     dotnet watch run --project AssetManagement.WebAPI
     ```

3. **Install Dependencies**:
   - Restore NuGet packages:
     ```bash
     dotnet restore
     ```

4. **Run the Application**:
   - Start the API:
     ```bash
     cd ./Hosts/AssetManagement.WebAPI
     dotnet watch run
     # or
     dotnet watch run --project AssetManagement.WebAPI
      ```
   - Access the Swagger UI at `https://localhost:7670` (or your configured port).

5. **Frontend Integration** (Optional):
   - The API is configured to allow CORS for. Ensure your frontend is hosted at this URL or update the CORS policy in `Program.cs`.

## Usage
- **Access the API**: Use Swagger UI or tools like Postman to interact with endpoints.
- **Authentication**:
  - Log in via `/api/auth/login` with a username and password to obtain JWT and refresh tokens.
  - Use the JWT token in the `Authorization` header (`Bearer <token>`) for protected endpoints.
- **Admin Operations**: Require the `Admin` role for creating, updating, or deleting assets, users, assignments, and categories.
- **Staff Operations**: Staff can view their assigned assets and assignments via `/api/assets/my-assets` and `/api/assignments/my-assignments`.

## API Endpoints
Below are key API endpoints (all prefixed with `/api/`):

### Auth
- **POST /auth/login**: Authenticate and receive JWT and refresh tokens.
- **GET /auth/refresh-token**: Refresh JWT using a refresh token.
- **POST /auth/logout**: Clear authentication cookies.
- **GET /auth/check**: Verify authentication status.
- **POST /auth/change-password**: Update user password.

### Assets
- **GET /assets**: List assets (Admin, paginated, filtered by category, state, etc.).
- **GET /assets/{assetCode}**: Get asset details by code (Admin).
- **POST /assets**: Create a new asset (Admin).
- **PUT /assets/{assetCode}**: Update an asset (Admin).
- **DELETE /assets/{assetCode}**: Delete an asset (Admin).
- **GET /assets/my-assets**: List assets assigned to the current user.

### Assignments
- **GET /assignments**: List assignments (Admin, paginated, filtered by state, date, etc.).
- **GET /assignments/{id}**: Get assignment details by ID (Admin).
- **POST /assignments**: Create a new assignment (Admin).
- **PUT /assignments/{id}**: Update an assignment (Admin).
- **DELETE /assignments/{id}**: Delete an assignment (Admin).
- **GET /assignments/my-assignments**: List assignments for the current user.

### Categories
- **GET /categories**: List all categories (Admin).
- **GET /categories/{categoryId}**: Get category details by ID (Admin).
- **POST /categories**: Create a new category (Admin).

### Returning Requests
- **GET /returnings**: List returning requests (Admin, paginated, filtered by state, date, etc.).

### Users
- **GET /users**: List users (Admin, paginated, filtered by type, location, etc.).
- **GET /users/{staffCode}**: Get user details by staff code (Admin).
- **POST /users**: Create a new user (Admin).
- **PUT /users/{staffCode}**: Update a user (Admin).
- **DELETE /users/{staffCode}**: Disable a user (Admin).

## License
This project is licensed under the **GNU General Public License v3.0 (GPL-3.0)**. You are free to use, modify, and distribute this software for personal, non-commercial purposes, provided that any derivative works are also licensed under GPL-3.0 and their source code is made publicly available. This license ensures that the project remains open-source and prevents proprietary use without sharing modifications.

See the [LICENSE](LICENSE) file for full details.

**Note**: This project is intended for personal learning and practical use. Unauthorized use in proprietary or commercial projects is prohibited under the GPL-3.0 license.

## Contributing
This is a personal project for self-practical purposes, and external contributions are not accepted at this time. If you have suggestions or feedback, feel free to contact the author.

## Contact
For inquiries or feedback, reach out to:
- **Author**: Vu Nguyen (Cao Nam)
- **Email**: [vunguyencaonam@gmail.com](vunguyencaonam@gmail.com)
- **GitHub**: [NoNameNo1F](https://github.com/NoNameNo1F)

---

### Notes on Updates
- **Project Name**: Kept as `VuNguyenPractical.AssetManagement` to reflect your personal branding.
- **Architecture**: Emphasized Clean Modulith, DDD, and Event-Driven design, as per your description and the solution structure.
- **Features**: Detailed based on the controllers, services, and DTOs in the provided code.
- **Technologies**: Updated to reflect .NET 9.0 and specific package versions (e.g., EF Core 9.0.5, FluentValidation 11.11.0).
- **License**: Chose GPL-3.0 to align with your goal of preventing others from using the project proprietarily, as discussed previously. The license ensures that any derivative work must be open-source.
- **Setup**: Included detailed steps for database configuration and running the project, addressing the SQL Server connection string in `appsettings.Development.json`.
- **API Endpoints**: Summarized based on the controllers (`AssetsController`, `AssignmentsController`, etc.).
- **Contributing**: Clarified that contributions are not accepted, as this is a personal project.

If you need further customizations (e.g., adding a logo, specific deployment instructions, or a different tone), please let me know! You can also provide your GitHub username or email for the contact section.