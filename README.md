# Media_Library_Project

A work-in-progress full-stack web application built with React and ASP.NET Core.

## Overview

Digital Library is an experimental project exploring the integration of a React frontend with an ASP.NET Core Web API backend. The current focus is establishing communication between the two, retrieving data through API endpoints, and building the foundation for a larger media library.

The application currently includes a basic interface for browsing different media categories, alongside API endpoints for testing frontend-to-backend communication and retrieving available media types.

## Running Locally

The frontend and backend run independently and require separate terminals.

### Backend

Navigate to the ASP.NET backend project directory and run:

\`\`\`bash
dotnet restore
dotnet run
\`\`\`

The backend currently runs locally at:

\`https://localhost:7061\`

### Frontend

Navigate to the React frontend directory containing \`package.json\` and run:

\`\`\`bash
npm install
npm run dev
\`\`\`

The frontend should be available at:

\`http://localhost:5173\`

### Development Notes

- Both applications must be running for frontend API requests to work.
- ASP.NET CORS is configured to allow requests from the local Vite development server.
- The ASP.NET HTTPS development certificate may need to be trusted locally:

\`\`\`bash
dotnet dev-certs https --trust
\`\`\`

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | \`/api/media-attributes/media-types\` | Retrieves available media categories. |
| POST | \`/api/test-connection\` | Tests communication between React and ASP.NET. |

## Future Development

The longer-term goal is to connect the application to an external database containing a large collection of media items.

Planned functionality includes:

- Storing and retrieving media records through the ASP.NET backend.
- Supporting multiple media types within a centralized library.
- Implementing search functionality across the collection.
- Adding sorting and filtering based on attributes such as title, genre, author, release date, and media type.
- Handling search and sorting operations on the backend to support larger datasets efficiently.

The project is currently focused on establishing the full-stack architecture before moving into database integration and more advanced library functionality.
