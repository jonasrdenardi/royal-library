# RoyalBook Project

The RoyalBook project consists of 2 applications: API and Web.

## API

Developed in .NET 7, the API utilizes the following technologies and patterns:

- CQRS: Although there are no separate read and write models, the project follows the Command Query Responsibility Segregation pattern for organizing commands and queries.
- MediatR: Implements the Mediator pattern, which complements CQRS and event handling.
- Entity Framework: Used as the ORM (Object-Relational Mapper) and repository pattern.
- Divided into the following layers:
  - `src`
    - `BackEnd`: Contains the applications responsible for handling client actions.
    - `Application`: Orchestrates requests.
    - `Domain`: Core of the application where entities, enums, interfaces, etc., reside.
    - `Service`: Contains business rules, handlers, etc.
    - `Infra`: Handles connections to infrastructure services such as databases, cache, SNS, SQS, etc.
    - `CrossCutting`: Houses operations that span the entire application, such as dependency injection.
  - `test`
    - `Unit`: Unit tests.
    - `Integration`: Integration tests.

## Web

The Web application is a React-based application divided into 3 main files:

- `App.tsx`: The main component.
- `SearchForm.tsx`: The form for entering search parameters.
- `DataTable.tsx`: The table for displaying search results.
