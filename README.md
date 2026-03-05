# Employee Management System

A comprehensive Windows Forms application for managing employee data, built with C# and Entity Framework.

## 📋 Project Overview

This Employee Management System provides a complete solution for managing employee information including departments, positions, and user accounts with role-based access control.

## 🏗️ Architecture

The project follows a three-tier architecture:

- **GUI Layer** (`EmployeeManagement.GUI`) - Windows Forms user interface
- **Business Logic Layer** (`EmployeeManagement.BLL`) - Business rules and logic
- **Data Access Layer** (`EmployeeManagement.DAL`) - Database operations

## 🚀 Features

- User authentication and authorization
- Employee management (Add, Edit, Delete, View)
- Department management
- Position management
- User account management
- Role-based access control

## 🛠️ Technologies Used

- **Framework:** .NET Framework
- **UI:** Windows Forms
- **ORM:** Entity Framework
- **Database:** SQL Server
- **Language:** C#

## 📦 Project Structure

```
Employee-Management/
│
├── final-project/
│   ├── EmployeeManagement.sln
│   │
│   ├── EmployeeManagement.GUI/        # Presentation Layer
│   │   ├── frmLogin.cs                # Login form
│   │   ├── frmMain.cs                 # Main form
│   │   ├── Mainform.cs                # Main interface
│   │   └── Resources/                 # Entity Framework models
│   │
│   ├── EmployeeManagement.BLL/        # Business Logic Layer
│   │   └── Class1.cs
│   │
│   └── EmployeeManagement.DAL/        # Data Access Layer
│       └── Class1.cs
```

## 📊 Database Schema

The system uses the following main entities:
- `tblEmployee` - Employee information
- `tblDepartment` - Department details
- `tblPosition` - Position/job titles
- `tblAccount` - User authentication and access control

## 💻 Installation & Setup

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.x
- SQL Server 2016 or later

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/FoatHit-BK/Employee-Management.git
   ```

2. Open `final-project/EmployeeManagement.sln` in Visual Studio

3. Update the database connection string in `App.Config`

4. Build the solution:
   - Right-click on Solution → Restore NuGet Packages
   - Build → Build Solution (F6)

5. Run the application:
   - Press F5 or click Start

## 🔐 Default Credentials

Please refer to your database for login credentials or configure them during first setup.

## 👨‍💻 Author

**FoatHit-BK**
- GitHub: [@FoatHit-BK](https://github.com/FoatHit-BK)
- Email: huynn422@uef.edu.vn

## 📝 License

This project is for educational purposes.

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

---

**Note:** This is a final project for academic purposes.
