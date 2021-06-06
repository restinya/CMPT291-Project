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
	street  varchar(10),
	postalCode nvarchar(6), 
	phoneNum int
);

/* Creating Employees table*/
create table Employee(
	empID	int primary key,
	fName	varchar(10),
	lName   varchar(12),
	city    varchar(10),
	street  varchar(10),
	postalCode nvarchar(6),
	phoneNum int,
	branchID int,
	foreign key(branchID) references Branch(branchID)
);

/* Creating Customer table*/
create table Customer(
	customerID int primary key, 
	fName varchar(10), 
	lName varchar(12),
	goldMember bit,
	city varchar(10), 
	street  varchar(10),
	postalCode nvarchar(6), 
	dateOfBirth date
);

/* Creating CarType table*/
create table CarType(
	carTypeID int primary key, 
	carClass varchar(20),
	dailyPricing int,
	weeklyPricing int,
	monthlyPricing int,
	lateFee int,
	changeBranch int
);

/*Creating Customer PhoneNum table*/
create table PhoneNum(
	customerID int primary key,
	phoneNum int,
	foreign key(customerID) references Customer(customerID)
);

/* Creating Cars table*/
create table Car(
	carID int primary key, 
	licensePlate nvarchar(6),
	status varchar(10),
	currentMileage int,
	transmissionType varchar(10),
	seats int,
	year int,
	make varchar(10),
	model varchar(10),
	carTypeID int,
	branchID int,
	foreign key(carTypeID) references CarType(carTypeID),
	foreign key(branchID) references Branch(branchID)
);

/* Creating Rental table*/
create table Rental(
	rentalID int primary key, 
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
