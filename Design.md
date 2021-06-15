## CMPT 291 Spring 2021

**Lab Instructor's Name**: Mohammed

**Group Members**: Joseph Latina, Courtney McNeilly, Mario Calderon, Neill Reyes

**Purpose**: A design documents that describes the design decisions made



### Entity-Relationship Diagram

![img](https://i.imgur.com/4e2icQK.png)

- The main entities in this E-R Diagram are the Employees, Customers, Branches, Rentals, Cars and CarTypes.
- There is a "Requested" relationship between Rentals and CarTypes because if a gold member customer is eligible for a free car upgrade during rental reservation, then the customer's requested car type would have to be recorded in order to override the selected car type pricing with their requested one. This only applies if the requested car type is not available in the time frame they had selected.
- Customers have a multi-valued attribute for phone numbers because there is an unknown number of phone numbers that a customer can have. This ensures flexibility in case the customer has more phone numbers than expected and avoids the situation where there is not enough columns in the Customers table.

### Integrity Constraints

![img](https://i.imgur.com/eM8OfSs.png)

###### Foreign Keys:

- **PhoneNum Table**: There is a relation schema for the customer's phone numbers since it is a multi-valued attribute. It references the customer ID as a foreign key from the Customer table. The customer ID together with the phone number entry is the primary key for that record.
- **Employee Table**: The Employee table's branchID is referenced as a foreign key from the Branch Table
- **Car Table**: The Car table's carTypeID is referenced as a foreign key from the Car Type table and the branchID is referenced as a foreign key from the Branch table
- **Rental Table**: The Rental table's customerID is referenced as a foreign key from the Customer table, employeeID from the Employee table, expectedCarTypeID from the Car Type table, carID from the Car table, and the pickUpBranchID and returnBranchID from the Branch table