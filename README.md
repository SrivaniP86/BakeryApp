🥐 BunBites Bakery - Full Stack Application

A modern, end-to-end e-commerce storefront built with a Vertical Slice Architecture.
This project demonstrates a production-ready connection between a .NET 9 Web API and an Angular 19 Frontend.

🚀 Technical Highlights Clean Architecture & Repository Pattern: Decoupled data access from the API Controller to ensure testability and maintainability.Asynchronous Programming: Fully implemented async/await throughout the data pipeline for high-performance I/O operations.Entity Framework Core (Code-First): Utilized Migrations for versioned database schema management and automated data seeding.Dependency Injection (DI): Managed service lifetimes using .NET's built-in IoC container (AddScoped).Modern Frontend: Built with Angular 19, featuring a responsive CSS Grid layout and real-time state management for the shopping cart.

🛠️ Tech StackLayerTechnology
Backend.NET 9 Web API, C#DatabaseSQL Server (EF Core)FrontendAngular 19, TypeScript, RxJSStylingModern CSS (Flexbox/Grid)

📂 Project StructurePlaintextBakeryApp/
├── BunAndFun.Api/        # .NET 9 Web API (Controllers, Repositories, Data)
└── BunAndFun-UI/         # Angular 19 Client (Components, Services, Assets)


⚙️ Setup & Installation
Backend Setup
Navigate to BunAndFun.Api/.Update the connection string in appsettings.json to point to your local SQL Server.Run the migrations to seed the database:Bashdotnet ef database update
Start the API:Bashdotnet run
Frontend SetupNavigate to BunAndFun-UI/.Install dependencies:Bashnpm install
Start the application:Bashng serve
Open your browser to http://localhost:4200.

<img width="1901" height="936" alt="image" src="https://github.com/user-attachments/assets/fb96ac63-29b8-4980-b7f6-15ebeb604e99" />

