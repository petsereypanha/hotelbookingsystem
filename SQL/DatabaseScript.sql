

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(15) NOT NULL,
    Address NVARCHAR(255) NOT NULL
);

CREATE TABLE Rooms (
    RoomId INT PRIMARY KEY IDENTITY(1,1),
    RoomType NVARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    AvailabilityStatus BIT NOT NULL
);
INSERT INTO Rooms (RoomType, Price, AvailabilityStatus)  
VALUES  
('Single', 50.00, 1),  
('Double', 80.00, 1),  
('Suite', 150.00, 1),  
('Deluxe', 200.00, 0),  
('Penthouse', 350.00, 1);


CREATE TABLE Bookings (
    BookingId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT NOT NULL,
    RoomId INT NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    PaymentStatus NVARCHAR(50) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId)
);
select * from Bookings;


CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    BookingId INT NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATETIME NOT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId)
);

CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Position NVARCHAR(50) NOT NULL,
    ContactInfo NVARCHAR(100) NOT NULL
);