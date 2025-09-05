# CSC260-FINAL - Social Media Site

**Ethan Townsend's Social Site** — A modern social media platform built with Blazor Server and .NET 8.

A comprehensive C#/Blazor dynamic web application that simulates a full-featured social media site, including user authentication, profile management, photo sharing, messaging, and administrative tools.

## Features

### User Management
- **Secure Authentication**: Registration and login with ASP.NET Core Identity
- **Strong Password Requirements**: 10+ characters with uppercase, lowercase, digits, and special characters
- **Role-based Authorization**: User and Admin role management

### Profile Features
- **Customizable Profiles**: Personal information including display name, bio, age, likes, and favorite food
- **Profile Photos**: Upload and display profile pictures
- **Public Profile Views**: View other users' profiles and information

### Social Interaction
- **Photo Sharing**: Upload and view photos with captions
- **Messaging System**: Leave messages on other users' profiles
- **User Search**: Find and connect with other users
- **Activity Tracking**: View messages received and sent

### Administrative Tools
- **Admin Dashboard**: Manage users and roles (admin privileges required)
- **User Management**: Administrative oversight of user accounts

## Technology Stack

- **Framework**: .NET 8.0
- **Web Framework**: ASP.NET Core with Blazor Server
- **Database**: SQL Server with Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **UI Components**: Razor Components with interactive server rendering
- **Styling**: Custom CSS with modern responsive design
- **Development Tools**: Visual Studio 2022

## Prerequisites

Before running this application, make sure you have:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB is sufficient for development)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended) or any compatible IDE

## Getting Started

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/snxethan/CSC260-FINAL.git
   cd CSC260-FINAL
   ```

2. **Navigate to the project directory**
   ```bash
   cd Social_Media
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Update the database**
   ```bash
   dotnet ef database update
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Open your browser** and navigate to `https://localhost:7021` or `http://localhost:5021`

### First Time Setup

1. **Create an account** using the "Create account" button on the home page
2. **Complete your profile** by navigating to your profile page and editing your information
3. **Upload a profile photo** to personalize your account
4. **Explore** other users and start interacting!

## Project Structure

```
Social_Media/
├── Components/
│   ├── Layout/          # Layout components (NavBar, MainLayout)
│   ├── Pages/           # Page components
│   │   ├── Admin/       # Admin-specific pages
│   │   ├── Index.razor  # Home page
│   │   ├── Me.razor     # User's own profile
│   │   ├── UserProfile.razor
│   │   ├── EditProfile.razor
│   │   ├── UserSearch.razor
│   │   └── About.razor
│   ├── MessageList.razor
│   ├── MessageForm.razor
│   └── PhotoCard.razor
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Seed.cs          # Database seeding
├── Models/
│   ├── ApplicationUser.cs
│   ├── Message.cs
│   └── Photo.cs
├── Migrations/          # Entity Framework migrations
├── wwwroot/            # Static files (CSS, JS, images)
├── Program.cs          # Application entry point
└── appsettings.json    # Configuration settings
```

## Key Features Overview

### Authentication & Security
- Secure user registration and login
- Password strength requirements
- User session management
- Role-based access control

### User Profiles
- Editable user profiles with personal information
- Profile photo upload and display
- Public profile viewing
- User discovery and search

### Social Features
- Photo sharing with captions
- Profile messaging system
- User-to-user communication
- Activity feeds

### Administration
- User role management
- Administrative dashboards
- User account oversight

## Contributing

This is a student project for CSC260 (Cohort 39). If you'd like to contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Development Notes

- This application uses Blazor Server for real-time interactivity
- Database migrations are automatically applied on startup in development
- Default admin user and roles are seeded on first run
- The application is configured for HTTPS by default

## About This Project

This social media platform was developed as part of CSC260 coursework to demonstrate proficiency with:
- Modern web development with .NET 8 and Blazor
- Database design and Entity Framework Core
- User authentication and security
- Component-based UI development
- Real-time web applications

## Author(s)

- [**Ethan Townsend (snxethan)**](www.ethantownsend.dev)
