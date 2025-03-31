# Hotel Booking System

## Overview
The Hotel Booking System is a C# Windows Forms application designed to facilitate hotel room bookings, manage customer information, and generate reports. The application utilizes SQL Server for data storage and implements various design patterns to ensure maintainability and scalability.

## Features
- **Room Booking**: Users can select rooms, enter customer details, and finalize bookings.
- **Customer Management**: Add, edit, and view customer information.
- **Room Management**: Manage room details including adding, updating, and deleting room information.
- **Reporting**: Generate reports related to bookings, customers, and room availability.

## Design Patterns Used
1. **Repository Pattern**: For data access and management of entities.
2. **Unit of Work Pattern**: To coordinate the work of multiple repositories.
3. **Factory Pattern**: For creating booking instances.
4. **Strategy Pattern**: For processing different payment methods.
5. **Observer Pattern**: To notify observers about booking changes.
6. **Singleton Pattern**: To manage a single instance of the database connection.
7. **Facade Pattern**: To provide a simplified interface for booking operations.

## Project Structure
```
HotelBookingSystem
├── src
│   ├── Program.cs
│   ├── Forms
│   │   ├── MainForm.cs
│   │   ├── BookingForm.cs
│   │   ├── CustomerForm.cs
│   │   ├── RoomManagementForm.cs
│   │   └── ReportForm.cs
│   ├── Models
│   │   ├── Booking.cs
│   │   ├── Customer.cs
│   │   ├── Room.cs
│   │   ├── Payment.cs
│   │   └── Employee.cs
│   ├── Data
│   │   ├── DatabaseContext.cs
│   │   ├── Repository
│   │   │   ├── IRepository.cs
│   │   │   ├── BookingRepository.cs
│   │   │   ├── CustomerRepository.cs
│   │   │   └── RoomRepository.cs
│   │   └── UnitOfWork.cs
│   ├── Services
│   │   ├── Factory
│   │   │   ├── IBookingFactory.cs
│   │   │   └── StandardBookingFactory.cs
│   │   ├── Strategy
│   │   │   ├── IPaymentStrategy.cs
│   │   │   └── CreditCardPaymentStrategy.cs
│   │   ├── Observer
│   │   │   ├── IObserver.cs
│   │   │   └── BookingNotifier.cs
│   │   ├── Singleton
│   │   │   └── DatabaseConnection.cs
│   │   └── Facade
│   │       └── BookingFacade.cs
│   └── Utils
│       └── Logger.cs
├── SQL
│   └── DatabaseScript.sql
├── App.config
├── HotelBookingSystem.csproj
└── README.md
```

## Setup Instructions
1. Clone the repository.
2. Open the solution in your preferred C# IDE.
3. Ensure that SQL Server is installed and running.
4. Update the connection string in `App.config` to point to your SQL Server instance.
5. Run the `DatabaseScript.sql` to create the necessary database schema.
6. Build and run the application.

## Usage
- Launch the application to access the main interface.
- Navigate through the forms to manage bookings, customers, and rooms.
- Generate reports to view booking statistics and customer information.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.