# Docker Compose Example

This project shows how to create a full stack - Angular frontend (folder my-frontend), C# backend (folder my-backend), and MySQL database (folder my-database), and wire them together using Docker compose.
There is an nginx reverse proxy (folder my-proxy) which routes traffic to the frontend and backend.
To build and run it, just run "docker compose up" at the project's root folder.
The server will be available at http://localhost:8080

When running, it shows just one table which displays numbers. You can add numbers.
The frontend calls the backend, which stores the numbers in the database.
The database is seeded with seed.sql.
