CREATE TABLE Customers (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255) NOT NULL
);

CREATE TABLE Rooms (
    Room_ID INT PRIMARY KEY IDENTITY(1,1),
    Room_Type NVARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    AvailabilityStatus BIT NOT NULL
);

CREATE TABLE Booking (
    Booking_ID INT PRIMARY KEY IDENTITY(1,1),
    Customer_ID INT FOREIGN KEY REFERENCES Customers(ID),
    Room_ID INT FOREIGN KEY REFERENCES Rooms(Room_ID),
    Start_Date DATETIME NOT NULL,
    End_Date DATETIME NOT NULL,
    Payment_Status NVARCHAR(50) NOT NULL,
    Total DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Booking_History (
    Booking_ID INT PRIMARY KEY FOREIGN KEY REFERENCES Booking(Booking_ID),
    Customer NVARCHAR(100) NOT NULL,
    Room_ID INT FOREIGN KEY REFERENCES Rooms(Room_ID),
    Start_Date DATETIME NOT NULL,
    End_Date DATETIME NOT NULL,
    Payment_Status NVARCHAR(50) NOT NULL
);