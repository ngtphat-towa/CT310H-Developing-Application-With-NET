﻿--As a principle when entering data into the Lab_ProductManagement database, we need to enter data for 2 tables DailyCustomer and Product first, then enter data for the ProductImports and Sales tables. The reason is that the ProductImports and Sales tables have foreign keys to the Product and DailyCustomer tables. If data is entered into the ProductImports or Sales table before entering data into the Product and DailyCustomer tables, a foreign key constraint violation error will occur.

--Similarly, if data is entered into the ProductImports table before entering data into the DailyCustomer and Product tables, and the value of the product code or the agent’s order number entered into the ProductImports table is not in the Product and DailyCustomer tables, a foreign key constraint violation error will occur. Try entering data into the ProductImports table before entering data into the DailyCustomer and Product tables and see the SQL SERVER error message to understand the meaning of cascade update.

--Similarly, if data is entered into the DailyCustomer and Product tables before entering data into the ProductImports and Sales tables and ensuring the validity of the data, no foreign key constraint violation error will occur. Try changing the product code in the Product table and opening the ProductImports table (including the Sales table) to observe the data and comment on the effect of cascade update in this case.

--To check whether cascade delete has been selected for the relationship between the Product and ProductImports tables (similarly with the relationship between the DailyCustomer and ProductImports tables), you can open the diagram of the Lab_ProductManagement database, right-click on the relationship between the Product and ProductImports tables, select properties and check whether cascade delete has been selected. Then, you can try to check the two cases of selecting cascade delete and deselecting cascade delete to understand the meaning of cascade delete. The result of deleting data in the Product table for each case will be different