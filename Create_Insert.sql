use [CarRental];

drop table Rental;
drop table Employee;
drop table PhoneNum;
drop table Car;
drop table Test;
drop table Branch;
drop table Customer;
drop table CarType;


/* Creating Branch table*/
create table Branch(
	branchID int primary key, 
	branchName varchar(15), 
	city varchar(10), 
	street  varchar(40),
	postalCode varchar(10), 
	phoneNum varchar(10),
);

/* Creating Employees table*/
create table Employee(
	empID	int primary key,
	fName	varchar(10),
	lName   varchar(12),
	city    varchar(10),
	street  varchar(40),
	postalCode varchar(10),
	phoneNum varchar(10),
	branchID int,
	foreign key(branchID) references Branch(branchID)
);

/* Creating Customer table*/
create table Customer(
	customerID int IDENTITY(1,1) PRIMARY KEY,
	fName varchar(10), 
	lName varchar(12),
	goldMember bit,
	city varchar(10), 
	[state] varchar(10),
	street  varchar(40),
	postalCode varchar(6), 
	dateOfBirth date,
);

/* Creating CarType table*/
create table CarType(
	carTypeID int primary key, 
	carClass varchar(20),
	dailyPricing float,
	weeklyPricing float,
	monthlyPricing float,
	lateFee float,
	changeBranch float
);

/*Creating Customer PhoneNum table*/
create table PhoneNum(
	customerID int,
	phoneNum varchar(10),
	foreign key(customerID) references Customer(customerID),
	constraint PK_PhoneNum primary key (customerID,phoneNum)
);

/* Creating Cars table*/
create table Car(
	carID int IDENTITY(1,1) PRIMARY KEY, 
	licensePlate varchar(10),
	[status] varchar(10),
	currentMileage int,
	transmissionType varchar(10),
	seats int,
	[year] int,
	make varchar(10),
	model varchar(10),
	carTypeID int,
	branchID int,
	foreign key(carTypeID) references CarType(carTypeID),
	foreign key(branchID) references Branch(branchID)
);

/* Creating Rental table*/
create table Rental(
	rentalID int IDENTITY(1,1) PRIMARY KEY, 
	pickUpDate date,
	expectedDate date,
	returnDate date,
	mileageUsed int,
	estimatedCost float, /*derived attribute*/
	totalFee float, /*derived attribute*/
	customerID int,
	employeeID int,
	expectedCarTypeID int,
	carID int,
	pickUpBranchID int,
	returnBranchID int,
	foreign key(customerID) references Customer(customerID),
	foreign key(employeeID) references Employee(empID),
	foreign key(expectedCarTypeID) references CarType(carTypeID),
	foreign key(carID) references Car(carID),
	foreign key(pickUpBranchID) references Branch(branchID),
	foreign key(returnBranchID) references Branch(branchID)
);

-- Insert Branches
insert into Branch values (1, 'Edmonton', 'Edmonton', 'Millwoods Drive', 'T6L5M5', '7806049803');
insert into Branch values (2, 'Calgary', 'Calgary', '11 Ave SW', 'T2R0E6', '7802348675');
insert into Branch values (3, 'Saskatoon', 'Saskatoon', '8th St', 'S7H0P7', '306284376');
/* insert into Branch values (4, 'Lloydminster', 'Lloydminster', 'Center St', 'T9V0G4', '3067613412'); */

-- Insert CarTypes
-- Weekly Discount: 5%, Monthly Discount: 10%
insert into CarType values (1, 'SUV', 34.70, 230.75, 936.90, 25.00, 25.00);
insert into CarType values (2, 'Standard', 56.70, 377.05, 1530.90, 25.00, 25.00);
insert into CarType values (3, 'Intermediate', 65.60, 436.24, 1771.20, 25.00, 25.00);
insert into CarType values (4, 'Luxury', 78.70, 523.35, 2124.90, 25.00, 25.00);

-- Insert Cars
-- SUVs
insert into Car values ('BXN2267', 'Available', 95000, 'Automatic', 5, 2020, 'Toyota', 'RAV4', 1, 1);
insert into Car values ('BXN3456', 'Available', 40000, 'Automatic', 5, 2019, 'Toyota', 'RAV4', 1, 1);
insert into Car values ('BXN4567', 'Available', 10000, 'Automatic', 5, 2018, 'Toyota', 'RAV4', 1, 2);
insert into Car values ('BXN6789', 'Available', 20000, 'Automatic', 5, 2017, 'Toyota', 'RAV4', 1, 3);
insert into Car values ('BXN0123', 'Available', 33000, 'Automatic', 5, 2021, 'Toyota', 'RAV4', 1, 3);
-- Standards
insert into Car values ('BXA7585', 'Available', 87000, 'Automatic', 4, 2021, 'Volkswagon', 'Jetta', 2, 1);
insert into Car values ('BXA3446', 'Available', 26000, 'Automatic', 4, 2020, 'Volkswagon', 'Jetta', 2, 2);
insert into Car values ('BXA6235', 'Available', 34000, 'Automatic', 4, 2019, 'Volkswagon', 'Jetta', 2, 3);
insert into Car values ('BXA1363', 'Available', 13000, 'Automatic', 4, 2018, 'Volkswagon', 'Jetta', 2, 1);
insert into Car values ('BXA9273', 'Available', 23000, 'Automatic', 4, 2017, 'Volkswagon', 'Jetta', 2, 2);
--Intermediates
insert into Car values ('BTS8256', 'Available', 45000, 'Automatic', 5, 2021, 'Kia Forte', 'Versa', 3, 1);
insert into Car values ('BTS4927', 'Available', 34000, 'Automatic', 5, 2020, 'Kia Forte', 'Versa', 3, 2);
insert into Car values ('BTS3017', 'Available', 33000, 'Automatic', 5, 2019, 'Kia Forte', 'Versa', 3, 3);
insert into Car values ('BTS9267', 'Available', 67000, 'Automatic', 5, 2018, 'Kia Forte', 'Versa', 3, 2);
insert into Car values ('BTS1023', 'Available', 12000, 'Automatic', 5, 2017, 'Kia Forte', 'Versa', 3, 3);
--Luxuries
insert into Car values ('BRN1903', 'Available', 43000, 'Automatic', 4, 2021, 'Cadillac', 'XTS', 4, 1);
insert into Car values ('BRN7534', 'Available', 22000, 'Automatic', 4, 2020, 'Cadillac', 'XTS', 4, 2);
insert into Car values ('BRN8234', 'Available', 76000, 'Automatic', 4, 2019, 'Cadillac', 'XTS', 4, 3);
insert into Car values ('BRN0198', 'Available', 45000, 'Automatic', 4, 2018, 'Cadillac', 'XTS', 4, 1);
insert into Car values ('BRN2893', 'Available', 27000, 'Automatic', 4, 2017, 'Cadillac', 'XTS', 4, 2);

-- Insert Employees
insert into Employee values (1, 'Michael', 'Scott', 'Edmonton', 'Terwilleger Dr', 'T6N7A3', '7805551234', 1);
insert into Employee values (2, 'Jim', 'Halpert', 'Edmonton', '111 Ave', 'T6N7A3', '7805551235', 1);
insert into Employee values (3, 'Pam', 'Beesly', 'Edmonton', '23 Ave', 'T6N7A3', '7805551236', 1);
insert into Employee values (4, 'Dwight', 'Schrute', 'Edmonton', 'Calgary Trail', 'T6N7A3', '7805551237', 1);
insert into Employee values (5, 'Angela', 'Martin', 'Calgary', '11th St', 'T6N7A3', '7805551238', 2);
insert into Employee values (6, 'Kelly', 'Kapoor', 'Calgary', '12th St', 'T6N7A3', '7805551239', 2);
insert into Employee values (7, 'Kevin', 'Malone', 'Calgary', '19th Ave', 'T6N7A3', '7805551239', 2);
insert into Employee values (8, 'Andy', 'Bernard', 'Calgary', '114th St', 'T6N7A3', '7805552345', 2);
insert into Employee values (9, 'Oscar', 'Martinez', 'Saskatoon', '8th Ave', 'S6V1T1', '7805552346', 3);
insert into Employee values (10, 'Phyllis', 'Vance', 'Saskatoon', '6th St', 'S9K2F4', '7805552347', 3);
insert into Employee values (11, 'Creed', 'Bratton', 'Saskatoon', '178th St', 'S7Y2K3', '7805552348', 3);
insert into Employee values (12, 'Stanley', 'Hudson', 'Saskatoon', '21 Ave', 'S7Y2L2', '7805552349', 3);

-- Insert Customers
insert into Customer values ('John', 'Doe', 1, 'Edmonton', 'AB', '235 114 St NW', 'T6N7N7', '1990-06-08');
insert into Customer values ('David', 'Rose', 1, 'Edmonton', 'AB', '111 115 Ave NW', 'T6V2C3', '1990-06-08');
insert into Customer values ('Moira', 'Rose', 1, 'Edmonton', 'AB', '87 Roland Road NW', 'T8K1M8', '1990-06-08');
insert into Customer values ('Alexis', 'Rose', 1, 'Calgary', 'AB', '629 Leeland Drive NW', 'T2X1N8', '1990-06-08');
insert into Customer values ('Johnny', 'Rose', 1, 'Calgary', 'AB', '12 Road Road NW', 'T2X3B9', '1990-06-08');
insert into Customer values ('Stevie', 'Budd', 0, 'Calgary', 'AB', '34 Street Drive SW', 'T2X1R2', '1990-06-08');
insert into Customer values ('Twyla', 'Sands', 0, 'Saskatoon', 'SK', '28 114 Ave NW', 'S8K2V2', '1990-06-08');
insert into Customer values ('Patrick', 'Brewer', 1, 'Saskatoon', 'SK', '58 56 St NW', 'S6V9S3', '1990-06-08');
insert into Customer values ('Roland', 'Schitt', 0, 'Saskatoon', 'SK', '27 Revel Drive NW', 'S6V9D1', '1990-06-08');
insert into Customer values ('Jocelyn', 'Schitt', 0, 'Saskatoon', 'SK', '3 Starling St NW', 'S8K6G4', '1990-06-08');
