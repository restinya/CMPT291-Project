## CMPT 291 Spring 2021

**Lab Instructor's Name**: Mohammed

**Group Members**: Joseph Latina, Courtney McNeilly, Mario Calderon, Neill Reyes

**Purpose**: A design documents that describes the design decisions made

### Goals

The goal of this program is to allow Rental Car Company to effectively manage a database of their fleet of cars, employees, customers, and  rental transactions, and to be able to modify the records when required. In addition, the program should satisfy the customer who will be looking to book their rental given specific parameters, the employee who will be completing the transactions on behalf of the customers, and the management team who will be running reports on the effectiveness of their branches.

### Entity-Relationship Diagram

![img](https://i.imgur.com/4e2icQK.png)

- The main entities in this E-R Diagram are the Employees, Customers, Branches, Rentals, Cars and CarTypes.
- There is a "Requested" relationship between Rentals and CarTypes because if a gold member customer is eligible for a free car upgrade during rental reservation, then the customer's requested car type would have to be recorded in order to override the selected car type pricing with their requested one. This only applies if the requested car type is not available in the time frame they had selected.
- There are two relationship sets between Rentals and Branches: PickUp and Return. This is to compare data to calculate the changeBranch fee if applicable.
- Customers have a multi-valued attribute for phone numbers because there is an unknown number of phone numbers that a customer can have. This ensures flexibility in case the customer has more phone numbers than expected and avoids the situation where there is not enough columns in the Customers table.
- The Rentals table make up the central entity that connects to all of the other entities in the E-R Diagram. It is total participatory for all of them except for CarTypes and the return Branch since those fields do not have to be necessarily filled when the record is first made.

### Integrity Constraints

![img](https://i.imgur.com/eM8OfSs.png)

###### Foreign Keys:

- **PhoneNum Table**: There is a relation schema for the customer's phone numbers since it is a multi-valued attribute. It references the customer ID as a foreign key from the Customer table. The customer ID together with the phone number entry is the primary key for that record.
- **Employee Table**: The Employee table's branchID is referenced as a foreign key from the Branch Table
- **Car Table**: The Car table's carTypeID is referenced as a foreign key from the Car Type table and the branchID is referenced as a foreign key from the Branch table
- **Rental Table**: The Rental table's customerID is referenced as a foreign key from the Customer table, employeeID from the Employee table, expectedCarTypeID from the Car Type table, carID from the Car table, and the pickUpBranchID and returnBranchID from the Branch table

###### Auto-Generated Primary Keys:

- ID numbers for the primary keys of the Car, Customer and Rental Tables are automatically generated and increments by 1 after every creation of new entries in the User Interface. 

