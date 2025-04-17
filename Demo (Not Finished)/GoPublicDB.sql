-- 1. Create the Database
CREATE DATABASE GoPublicDB;
GO
USE GoPublicDB;

-- 2. Create Tables

CREATE TABLE Customer (
    customerId VARCHAR(36) PRIMARY KEY,
    customerName VARCHAR(100),
    phoneNumber VARCHAR(15)
);

CREATE TABLE TicketVendorMachine (
    machineId VARCHAR(36) PRIMARY KEY
);

CREATE TABLE Route (
    routeId VARCHAR(36) PRIMARY KEY,
    routeName VARCHAR(100),
    descStart VARCHAR(100),
    descEnd VARCHAR(100),
    duration TIME
);

CREATE TABLE PublicTransportations (
    vehicleId VARCHAR(36) PRIMARY KEY,
    vehicleType VARCHAR(50)
);

CREATE TABLE Destination (
    destinationId VARCHAR(36) PRIMARY KEY,
    vehicleId VARCHAR(36),
    routeId VARCHAR(36),
    FOREIGN KEY (vehicleId) REFERENCES PublicTransportations(vehicleId),
    FOREIGN KEY (routeId) REFERENCES Route(routeId)
);

CREATE TABLE Ticket (
    ticketId VARCHAR(36) PRIMARY KEY,
    customerId VARCHAR(36),
    machineId VARCHAR(36),
    routeName VARCHAR(100),
    descStart VARCHAR(100),
    descEnd VARCHAR(100),
    vehicleType VARCHAR(50),
    FOREIGN KEY (customerId) REFERENCES Customer(customerId),
    FOREIGN KEY (machineId) REFERENCES TicketVendorMachine(machineId)
);

CREATE TABLE LogTicket (
    logTicketId VARCHAR(36) PRIMARY KEY,
    machineId VARCHAR(36),
    customerId VARCHAR(36),
    ticketId VARCHAR(36),
    FOREIGN KEY (machineId) REFERENCES TicketVendorMachine(machineId),
    FOREIGN KEY (customerId) REFERENCES Customer(customerId),
    FOREIGN KEY (ticketId) REFERENCES Ticket(ticketId)
);

CREATE TABLE PaymentMethod (
    paymentId VARCHAR(36) PRIMARY KEY,
    qrCodeId VARCHAR(36),
    creditCardId VARCHAR(36)
);

CREATE TABLE QRCode (
    qrCodeId VARCHAR(36) PRIMARY KEY,
    isActive VARCHAR(10),
    field VARCHAR(100)
);

CREATE TABLE CreditCard (
    creditCardId VARCHAR(36) PRIMARY KEY,
    isActive VARCHAR(10),
    field VARCHAR(100)
);

-- Inserting records for Customer table
INSERT INTO Customer (customerId, customerName, phoneNumber)
VALUES
    ('CUST001', 'Alice Smith', '0912345678'),
    ('CUST002', 'Bob Johnson', '0923456789'),
    ('CUST003', 'Charlie Brown', '0934567890'),
    ('CUST004', 'David White', '0945678901'),
    ('CUST005', 'Eva Green', '0956789012'),
    ('CUST006', 'Frank Black', '0967890123'),
    ('CUST007', 'Grace Lee', '0978901234'),
    ('CUST008', 'Hannah Blue', '0989012345'),
    ('CUST009', 'Ivy Adams', '0990123456'),
    ('CUST010', 'Jack Taylor', '0901234567'),
    ('CUST011', 'Kylie King', '0914678901'),
    ('CUST012', 'Liam Young', '0925789012'),
    ('CUST013', 'Mia Walker', '0936890123'),
    ('CUST014', 'Noah Scott', '0947901234'),
    ('CUST015', 'Olivia Harris', '0958012345');

-- Inserting records for TicketVendorMachine table
INSERT INTO TicketVendorMachine (machineId)
VALUES
    ('MACHINE001'),
    ('MACHINE002'),
    ('MACHINE003'),
    ('MACHINE004'),
    ('MACHINE005'),
    ('MACHINE006'),
    ('MACHINE007'),
    ('MACHINE008'),
    ('MACHINE009'),
    ('MACHINE010'),
    ('MACHINE011'),
    ('MACHINE012'),
    ('MACHINE013'),
    ('MACHINE014'),
    ('MACHINE015');

-- Inserting records for Route table
INSERT INTO Route (routeId, routeName, descStart, descEnd, duration)
VALUES
    ('ROUTE001', 'Route A', 'Central Park', 'Main Station', '00:30:00'),
    ('ROUTE002', 'Route B', 'South Station', 'North Station', '00:45:00'),
    ('ROUTE003', 'Route C', 'East Side', 'West End', '01:00:00'),
    ('ROUTE004', 'Route D', 'City Center', 'Airport', '00:35:00'),
    ('ROUTE005', 'Route E', 'Suburb Area', 'Downtown', '00:40:00'),
    ('ROUTE006', 'Route F', 'Shopping Mall', 'University', '00:50:00'),
    ('ROUTE007', 'Route G', 'Park Avenue', 'Old Town', '01:10:00'),
    ('ROUTE008', 'Route H', 'Bus Terminal', 'City Hall', '01:00:00'),
    ('ROUTE009', 'Route I', 'Beach Road', 'Harbor', '00:55:00'),
    ('ROUTE010', 'Route J', 'Train Station', 'Museum District', '00:25:00'),
    ('ROUTE011', 'Route K', 'Tech Park', 'Industrial Zone', '00:45:00'),
    ('ROUTE012', 'Route L', 'Cultural District', 'Suburban Area', '00:30:00'),
    ('ROUTE013', 'Route M', 'Highway', 'Bridge', '01:00:00'),
    ('ROUTE014', 'Route N', 'Market Square', 'Library', '00:50:00'),
    ('ROUTE015', 'Route O', 'Stadium', 'Football Field', '01:20:00');

-- Inserting records for PublicTransportations table
INSERT INTO PublicTransportations (vehicleId, vehicleType)
VALUES
    ('VEHICLE001', 'BUS'),
    ('VEHICLE002', 'MRT'),
    ('VEHICLE003', 'BUS'),
    ('VEHICLE004', 'MRT'),
    ('VEHICLE005', 'BUS'),
    ('VEHICLE006', 'MRT'),
    ('VEHICLE007', 'BUS'),
    ('VEHICLE008', 'MRT'),
    ('VEHICLE009', 'BUS'),
    ('VEHICLE010', 'MRT'),
    ('VEHICLE011', 'BUS'),
    ('VEHICLE012', 'MRT'),
    ('VEHICLE013', 'BUS'),
    ('VEHICLE014', 'MRT'),
    ('VEHICLE015', 'BUS');

-- Inserting records for Destination table
INSERT INTO Destination (destinationId, vehicleId, routeId)
VALUES
    ('DEST001', 'VEHICLE001', 'ROUTE001'),
    ('DEST002', 'VEHICLE002', 'ROUTE002'),
    ('DEST003', 'VEHICLE003', 'ROUTE003'),
    ('DEST004', 'VEHICLE004', 'ROUTE004'),
    ('DEST005', 'VEHICLE005', 'ROUTE005'),
    ('DEST006', 'VEHICLE006', 'ROUTE006'),
    ('DEST007', 'VEHICLE007', 'ROUTE007'),
    ('DEST008', 'VEHICLE008', 'ROUTE008'),
    ('DEST009', 'VEHICLE009', 'ROUTE009'),
    ('DEST010', 'VEHICLE010', 'ROUTE010'),
    ('DEST011', 'VEHICLE011', 'ROUTE011'),
    ('DEST012', 'VEHICLE012', 'ROUTE012'),
    ('DEST013', 'VEHICLE013', 'ROUTE013'),
    ('DEST014', 'VEHICLE014', 'ROUTE014'),
    ('DEST015', 'VEHICLE015', 'ROUTE015');

-- Inserting records for Ticket table
-- INSERT INTO Ticket (ticketId, customerId, machineId, routeName, descStart, descEnd, vehicleType)
-- VALUES
--     ('TICKET001', 'CUST001', 'MACHINE001', 'Route A', 'Central Park', 'Main Station', 'BUS'),
--     ('TICKET002', 'CUST002', 'MACHINE002', 'Route B', 'South Station', 'North Station', 'MRT'),
--     ('TICKET003', 'CUST003', 'MACHINE003', 'Route C', 'East Side', 'West End', 'BUS'),
--     ('TICKET004', 'CUST004', 'MACHINE004', 'Route D', 'City Center', 'Airport', 'MRT'),
--     ('TICKET005', 'CUST005', 'MACHINE005', 'Route E', 'Suburb Area', 'Downtown', 'BUS'),
--     ('TICKET006', 'CUST006', 'MACHINE006', 'Route F', 'Shopping Mall', 'University', 'MRT'),
--     ('TICKET007', 'CUST007', 'MACHINE007', 'Route G', 'Park Avenue', 'Old Town', 'BUS'),
--     ('TICKET008', 'CUST008', 'MACHINE008', 'Route H', 'Bus Terminal', 'City Hall', 'MRT'),
--     ('TICKET009', 'CUST009', 'MACHINE009', 'Route I', 'Beach Road', 'Harbor', 'BUS'),
--     ('TICKET010', 'CUST010', 'MACHINE010', 'Route J', 'Train Station', 'Museum District', 'MRT'),
--     ('TICKET011', 'CUST011', 'MACHINE011', 'Route K', 'Tech Park', 'Industrial Zone', 'BUS'),
--     ('TICKET012', 'CUST012', 'MACHINE012', 'Route L', 'Cultural District', 'Suburban Area', 'MRT'),
--     ('TICKET013', 'CUST013', 'MACHINE013', 'Route M', 'Highway', 'Bridge', 'BUS'),
--     ('TICKET014', 'CUST014', 'MACHINE014', 'Route N', 'Market Square', 'Library', 'MRT'),
--     ('TICKET015', 'CUST015', 'MACHINE015', 'Route O', 'Stadium', 'Football Field', 'BUS');

-- Inserting records for LogTicket table
-- INSERT INTO LogTicket (logTicketId, machineId, customerId, ticketId)
-- VALUES
--     ('LOGTICKET001', 'MACHINE001', 'CUST001', 'TICKET001'),
--     ('LOGTICKET002', 'MACHINE002', 'CUST002', 'TICKET002'),
--     ('LOGTICKET003', 'MACHINE003', 'CUST003', 'TICKET003'),
--     ('LOGTICKET004', 'MACHINE004', 'CUST004', 'TICKET004'),
--     ('LOGTICKET005', 'MACHINE005', 'CUST005', 'TICKET005'),
--     ('LOGTICKET006', 'MACHINE006', 'CUST006', 'TICKET006'),
--     ('LOGTICKET007', 'MACHINE007', 'CUST007', 'TICKET007'),
--     ('LOGTICKET008', 'MACHINE008', 'CUST008', 'TICKET008'),
--     ('LOGTICKET009', 'MACHINE009', 'CUST009', 'TICKET009'),
--     ('LOGTICKET010', 'MACHINE010', 'CUST010', 'TICKET010'),
--     ('LOGTICKET011', 'MACHINE011', 'CUST011', 'TICKET011'),
--     ('LOGTICKET012', 'MACHINE012', 'CUST012', 'TICKET012'),
--     ('LOGTICKET013', 'MACHINE013', 'CUST013', 'TICKET013'),
--     ('LOGTICKET014', 'MACHINE014', 'CUST014', 'TICKET014'),
--     ('LOGTICKET015', 'MACHINE015', 'CUST015', 'TICKET015');

-- Inserting records for PaymentMethod table
INSERT INTO PaymentMethod (paymentId, qrCodeId, creditCardId)
VALUES
    ('PAY001', 'QR001', 'CC001'),
    ('PAY002', 'QR002', 'CC002'),
    ('PAY003', 'QR003', 'CC003'),
    ('PAY004', 'QR004', 'CC004'),
    ('PAY005', 'QR005', 'CC005'),
    ('PAY006', 'QR006', 'CC006'),
    ('PAY007', 'QR007', 'CC007'),
    ('PAY008', 'QR008', 'CC008'),
    ('PAY009', 'QR009', 'CC009'),
    ('PAY010', 'QR010', 'CC010'),
    ('PAY011', 'QR011', 'CC011'),
    ('PAY012', 'QR012', 'CC012'),
    ('PAY013', 'QR013', 'CC013'),
    ('PAY014', 'QR014', 'CC014'),
    ('PAY015', 'QR015', 'CC015');

-- Inserting records for QRCode table
INSERT INTO QRCode (qrCodeId, isActive, field)
VALUES
    ('QR001', 'true', 'Pay for Bus Ticket'),
    ('QR002', 'true', 'Pay for MRT Ticket'),
    ('QR003', 'true', 'Pay for Bus Ticket'),
    ('QR004', 'true', 'Pay for MRT Ticket'),
    ('QR005', 'true', 'Pay for Bus Ticket'),
    ('QR006', 'true', 'Pay for MRT Ticket'),
    ('QR007', 'true', 'Pay for Bus Ticket'),
    ('QR008', 'true', 'Pay for MRT Ticket'),
    ('QR009', 'true', 'Pay for Bus Ticket'),
    ('QR010', 'true', 'Pay for MRT Ticket'),
    ('QR011', 'true', 'Pay for Bus Ticket'),
    ('QR012', 'true', 'Pay for MRT Ticket'),
    ('QR013', 'true', 'Pay for Bus Ticket'),
    ('QR014', 'true', 'Pay for MRT Ticket'),
    ('QR015', 'true', 'Pay for Bus Ticket');

-- Inserting records for CreditCard table
INSERT INTO CreditCard (creditCardId, isActive, field)
VALUES
    ('CC001', 'true', 'Visa'),
    ('CC002', 'true', 'MasterCard'),
    ('CC003', 'true', 'American Express'),
    ('CC004', 'true', 'Discover'),
    ('CC005', 'true', 'Visa'),
    ('CC006', 'true', 'MasterCard'),
    ('CC007', 'true', 'American Express'),
    ('CC008', 'true', 'Discover'),
    ('CC009', 'true', 'Visa'),
    ('CC010', 'true', 'MasterCard'),
    ('CC011', 'true', 'American Express'),
    ('CC012', 'true', 'Discover'),
    ('CC013', 'true', 'Visa'),
    ('CC014', 'true', 'MasterCard'),
    ('CC015', 'true', 'American Express');
