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
	customerID int primary key,
	phoneNum varchar(10),
	foreign key(customerID) references Customer(customerID)
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
	estimatedCost int, /*derived attribute*/
	totalFee int, /*derived attribute*/
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

create table Test(
	rentalID int primary key, 
	pickUpDate varchar(10),
	expectedDate varchar(10),
	requestedClass varchar(10),
	goldMember varchar(10)
);


insert into Branch values (1, 'Edmonton', 'Edmonton', 'Millwoods', 'T6L5M5', '7806049803');
insert into CarType values (1, 'Intermediate SUV', 56.60, 250.50, 800.25, 25.00, 25.00);
insert into CarType values (2, 'Compact', 34.70, 230.50, 750.25, 25.00, 25.00);
insert into Car values ('BXN2267', 'Available', 95000, 'Automatic', 5, 2020, 'Toyota', 'RAV4', 1, 1);
insert into Car values ('BXA7585', 'Available', 97000, 'Automatic', 5, 2020, 'Nissan', 'Versa', 2, 1);
insert into Employee values (1, 'Ryan', 'Tran', 'Edmonton', 'Terwilleger', 'T6N7A3', '7805689380', 1);
insert into Customer values ('John', 'Doe', 1, 'Edmonton', 'AB', '235 Huntington Hill NW', 'T6N7N7', '1990-06-08');
