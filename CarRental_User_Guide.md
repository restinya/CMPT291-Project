## Car Rental User Guide

### Booking a New Rental Reservation:

![image-20210614155313607](C:\Users\josep\AppData\Roaming\Typora\typora-user-images\image-20210614155313607.png)

1. Click on "New Rental Transaction" from the Employee Display Screen.

2. Click on the dropdown menu for Employee ID and select the Employee that will be conducting the transaction.

3. Click on the dropdown menu for the list of existing customers. If it is a new customer, select the checkbox "Select If New Customer" and a form for customers will pop on the side. Fill out the form for the new customer's details and hit "Add". A message string will be generated with the newly created customer ID. You can now select the new customer in the drop down menu for Customer ID.

   ![image-20210614155426082](C:\Users\josep\AppData\Roaming\Typora\typora-user-images\image-20210614155426082.png)

4. Click on "Check Gold Membership" to check if an existing customer is a gold member. If so, the requested Vehicle Class drop down menu will be available for the user to select.

   ![image-20210614155841409](C:\Users\josep\AppData\Roaming\Typora\typora-user-images\image-20210614155841409.png)

5. Select the "Pick-Up Branch ID" and click on the checkbox "Select If Different Return Branch" to select the returning branch ID if the customer is planning to return the rental car to another branch.

6. Fill out the Pick-Up Date and Expected Return Date.

7. Click on "Find Available Cars" to list out the rental cars available with the parameters selected.

8. Select the rental car that the customer is interested in and click on "Calculate Estimated Cost" to display the estimated outstanding cost for the customer.

9. Click on "Submit" to create the new rental record in the database. Note that the system will not allow you to continue with submit if the above fields have not been filled and if the "Calculate Estimate Cost" button was not clicked.

### Returning a Rental Car:

![image-20210614155626764](C:\Users\josep\AppData\Roaming\Typora\typora-user-images\image-20210614155626764.png)

1. Click on the dropdown menu for Customer ID to select the customer that is returning the rental car.
2. Click on "Load Ongoing Rentals" to display the ongoing rental records that have not been closed yet and select the record corresponding to the right rental car.
3. Fill out the Return Date, Return Branch and Mileage Used fields to continue with the return process.
4. Click on "Calculate Total Fee" to display the breakdown of cost that will be charged to the customer. It will list out the "Base Fee" which is the number of days the car was rented for multiplied by the price fee of the car type. The "Late Fee" section will only list out the late cost if the customer returned the rental car later than the expected date. The "Diff Branch Fee" section will only list out the change branch cost if the customer returned the rental car at a different branch than it was originally picked up from. This fee will be waived if the customer is a Gold Member.
5. Once the total fee is displayed, click on "Submit" to update the rental record and close it. Note that the system will only allow you to continue with submit if the above fields have been filled and if "Calculate Total Fee" was clicked.

### Viewing and Modifying Car Records

![image-20210614155723941](C:\Users\josep\AppData\Roaming\Typora\typora-user-images\image-20210614155723941.png)

###### Adding a New Car Record:

- Once the employee logs in, all existing cars will automatically load on the table. If the user wants to add a new car record, the form on the right side needs to be filled out. Click on "Add" to create the new record in the database. The new record will automatically be displayed on the table.

###### Viewing Car Records:

- If the employee wants to filter the car records with "Branch" and "Vehicle Class" parameters, simply select from the drop down menus. Click on "Load" to load the filtered car records and click on "Clear Filters" if the user wants to clear the filters.

###### Modifying Car Records:

- Select the record to be modified on the table and double click on the cell that needs to be modified. Once all of the values for the selected record is updated, click on "Modify". There will be a confirmation message that will pop up. Select "Yes" and the record will be updated in the database.
- ![image-20210614160649239](C:\Users\josep\AppData\Roaming\Typora\typora-user-images\image-20210614160649239.png)

###### Deleting Car Records:

- Select the record to be deleted on the table. Click "Delete" and a confirmation message will pop up. Select "Yes" and the record will then be deleted from the database.