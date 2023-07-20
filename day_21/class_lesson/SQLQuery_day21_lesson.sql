/*
Day 21 Lesson:
1. SQL Store Procedure
2. SQL Functions
*/

-- Sample Data Table:
USE MyLocalDb

CREATE TABLE [EmployeeDetails] (
	[ID] [bigint] NOT NULL,
	[FirstName] [nvarchar](50),
	[LastName] [nvarchar](50),
	[Address] [nvarchar](50),
	[UpdatedDate] [datetime] DEFAULT GETDATE(),
	CONSTRAINT [PK_EmployeeDetails] PRIMARY KEY CLUSTERED (ID)
)


 INSERT INTO [EmployeeDetails] ([ID], [FirstName], [LastName], [Address])
VALUES 
    (1, 'CHIN', 'YEN', '123 LAB ASSISTANT ST'),
    (2, 'MIKE', 'PEARL', 'XYZ SENIOR ACCOUNTANT DR'),
    (3, 'GREEN', 'FIELD', 'ABC ACCOUNTANT CIR'),
    (4, 'DEWANE', 'PAUL', '112 PROGRAMMER AVE'),
    (5, 'MATTS', 'SR.', '124 PROGRAMMER HWY'),
    (6, 'PLANK', 'OTO', '717 ACCOUNTANT FM RD')

-- Store Procedure:
/*
A stored procedure is a prepared SQL code that you can save, so the code can be reused over and over again.
So if you have an SQL query that you write over and over again, save it as a stored procedure, and then just call it to execute it.
You can also pass parameters to a stored procedure, so that the stored procedure can act based on the parameter value(s) that is passed.

Creating a Stored Procedure SYNTAX:

CREATE PROCEDURE procedure_name
AS
sql_statement
GO;

Executing a Stored Procedure SYNTAX:

EXEC procedure_name;

-- TEMPLATE for a Store Procedure:

-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ashik Khulal
-- Create date: 07/19/2023
-- Description:	Gets employees details from [EmployeeDetails] table
-- =============================================
CREATE PROCEDURE usp_GetEmployeeDetails 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON

    -- Any SQL query to execute!
	SELECT * FROM [EmployeeDetails]
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ashik Khulal
-- Create date: 07/19/2023
-- Description:	Adds employees details into [EmployeeDetails] table
-- =============================================
CREATE PROCEDURE usp_AddEmployeeDetails 
	-- Add the parameters for the stored procedure here
	@ID bigint,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Address nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON

    -- Insert statements for procedure here
	INSERT INTO [EmployeeDetails] VALUES (@ID, @FirstName, @LastName, @Address, GETDATE())
END
GO

-- Executing usp_GetEmployeeDetails store procedure
EXEC usp_GetEmployeeDetails

-- Executing usp_AddEmployeeDetails store procedure
EXEC usp_AddEmployeeDetails 7, 'MAX', 'OTOOVAN', '1000 ECON FM RD'

-- SQL Functions:
/*
One of the most powerful features of SQL is the ability to use functions to perform various operations on the data in a database.

-- Pre-built / System functions: SQL has many built-in functions for performing calculations on data.

Aggregate Functions: Aggregate functions are used to perform calculations on a set of values and return a single result. Some of the most commonly used aggregate functions in SQL include −

COUNT() - Returns the number of rows in a table or the number of non-NULL values in a column
SUM() - Returns the sum of all non-NULL values in a column
AVG() - Returns the average of all non-NULL values in a column
MIN() - Returns the minimum value in a column
MAX() - Returns the maximum value in a column

*/

SELECT COUNT(*) FROM [EmployeeDetails];
SELECT SUM(ID) FROM [EmployeeDetails];

/*
Scalar Functions: Scalar functions are used to perform calculations on a single value and return a single result. Some examples of scalar functions in SQL include −

LENGTH() - Returns the number of characters in a string
UPPER() - Converts a string to uppercase
LOWER() - Converts a string to lowercase
CONCAT() - Concatenates two or more strings together
ROUND() - Rounds a number to a specified number of decimal places

*/
SELECT UPPER(FirstName) FROM [EmployeeDetails];

SELECT ROUND(total_cost, 2) FROM orders; -- imagine a sample order table

/*
Date and Time Functions: SQL also provides a number of functions for working with date and time values. Some examples of date and time functions in SQL include −

NOW() - Returns the current date and time
CURRENT_DATE() - Returns the current date
CURRENT_TIME() - Returns the current time
YEAR() - Returns the year of a date
MONTH() - Returns the month of a date
DAY() - Returns the day of a date
*/

SELECT NOW();
SELECT MONTH(UpdatedDate) FROM [EmployeeDetails];

/*
String Functions: SQL also provides a number of string manipulation function. Some examples of string functions in SQL include −

LTRIM() - Removes the leading whitespace of the string
RTRIM() - Removes the trailing whitespace of the string
TRIM() - Removes both leading and trailing whitespace of the string
SUBSTRING() - Extracts a specific portion of a string
REPLACE() - Replaces all occurrences of a specified string with another string
*/

/*
Conditional Functions: SQL also provides a number of functions that perform different actions based on certain conditions. Some examples of conditional functions in SQL include −

CASE - evaluates a list of conditions and returns a result for the first condition that is met
IF - return a specified value if the condition is met, otherwise return another specified value
COALESCE - return the first non-null expression among multiple expressions.
*/
-- Here's an example of using the CASE function to assign a label to each order based on the total cost (a hypothetical order table) −
SELECT order_id, total_cost,
   CASE 
      WHEN total_cost > 100 THEN 'expensive'
      WHEN total_cost > 50 THEN 'moderately priced'
      ELSE 'inexpensive'
   END as "price range"
FROM orders;

-- Here's an example of using the IF function to check the availability of stock of a product (a hypothetical order table) -
SELECT product_name,
   IF(stock_quantity > 0, 'In Stock', 'Out of Stock') as
   "Availability"
FROM products;

-- Here's an example of using the COALESCE function to display the primary phone number and the secondary phone number of a customer (a hypothetical order table) −
SELECT customer_name,
   COALESCE(primary_phone, secondary_phone) as "Phone Number"
FROM customers;

/*
Logical Functions: SQL provides a set of logical functions that return a Boolean value, which can be either true or false. Some examples of logical functions in SQL include −

AND - Returns true if both the conditions are true
OR - Returns true if at least one of the conditions is true
NOT - Negates a boolean value
*/

SELECT customer_name, city, account_balance
FROM customers
WHERE city = 'New York' AND account_balance > 1000;

/*
Conversion Functions: SQL provides a number of functions that can be used to convert data from one type to another. Some examples of conversion functions in SQL include −

CAST() - Converts a value from one data type to another
CONVERT() - Converts a value from one data type to another (This function is specific for some database vendors like SQL Server)
TO_DATE() - Converts a string to a date value
TO_TIME() - Converts a string to a time value
TO_TIMESTAMP() - Converts a string to a timestamp value
*/

SELECT CAST(price AS INT) as "Integer Price"
FROM products;

SELECT TO_DATE(order_date, 'yyyy-mm-dd') as "Formatted Order Date"
FROM orders;

/*
Window Functions
SQL provides a set of functions that can be used to perform calculations across a set of rows that are related to the current row. These functions are known as window functions. Some examples of window functions in SQL include −
RANK() - Assigns a unique rank to each row within a result set, based on the values in one or more columns
DENSE_RANK() - Assigns a unique rank to each row within a result set, based on the values in one or more columns, but does not leave gaps in the ranking sequence when there are ties
ROW_NUMBER() - Assigns a unique number to each row within a result set, based on the order specified in the ORDER BY clause of the function
*/

SELECT customer_name, account_balance, RANK() OVER (ORDER BY account_balance DESC) as "Rank"
FROM customers;

SELECT customer_name, ROW_NUMBER() OVER (ORDER BY customer_id) as "Row Number"
FROM customers;

-- User defined functions: Like functions in programming languages, SQL Server user-defined functions are routines that accept parameters, perform an action, such as a complex calculation, and return the result of that action as a value. The return value can either be a single scalar value or a result set.

-- 1. Inline Table-valued Functions: For an inline table-valued function, there is no function body; the table is the result set of a single SELECT statement.

-- TEMPLATE:
/*
-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION <Inline_Function_Name, sysname, FunctionName> 
(	
	-- Add the parameters for the function here
	<@param1, sysname, @p1> <Data_Type_For_Param1, , int>, 
	<@param2, sysname, @p2> <Data_Type_For_Param2, , char>
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT 0
)
GO
*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Author:		Ashik Khulal
-- Create date: 07/19/2023
-- Description:	A simple function to with select syntax for our [EmployeeDetails] table
-- ==========================================================================================
CREATE FUNCTION fudf_GetEmployeesDetails()
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT * FROM [EmployeeDetails]
)
GO

-- Executing above function:
SELECT * FROM dbo.fudf_GetEmployeesDetails();

-- 2. Multi-statement Table-valued Function: Multi-statement table-valued function returns a table as output and this output table structure can be defined by the user. MSTVFs can contain only one statement or more than one statement. Also, we can modify and aggregate the output table in the function body. 

-- TEMPLATE:
/*
-- ================================================
-- Template generated from Template Explorer using:
-- Create Multi-Statement Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION <Table_Function_Name, sysname, FunctionName> 
(
	-- Add the parameters for the function here
	<@param1, sysname, @p1> <data_type_for_param1, , int>, 
	<@param2, sysname, @p2> <data_type_for_param2, , char>
)
RETURNS 
<@Table_Variable_Name, sysname, @Table_Var> TABLE 
(
	-- Add the column definitions for the TABLE variable here
	<Column_1, sysname, c1> <Data_Type_For_Column1, , int>, 
	<Column_2, sysname, c2> <Data_Type_For_Column2, , int>
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	
	RETURN 
END
GO
*/

-- 3. Scalar-valued Function: User-defined scalar functions return a single data value of the type defined in the RETURNS clause. For an inline scalar function, the returned scalar value is the result of a single statement.

-- TEMPLATE:
/*
-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION <Scalar_Function_Name, sysname, FunctionName> 
(
	-- Add the parameters for the function here
	<@Param1, sysname, @p1> <Data_Type_For_Param1, , int>
)
RETURNS <Function_Data_Type, ,int>
AS
BEGIN
	-- Declare the return variable here
	DECLARE <@ResultVar, sysname, @Result> <Function_Data_Type, ,int>

	-- Add the T-SQL statements to compute the return value here
	SELECT <@ResultVar, sysname, @Result> = <@Param1, sysname, @p1>

	-- Return the result of the function
	RETURN <@ResultVar, sysname, @Result>

END
GO
*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION fudf_SimpleInterestCalc 
(
	-- Add the parameters for the function here
	@Principal decimal(18,2),
	@Rate decimal(18,2),
	@Time int
)
RETURNS decimal(18,2)
AS
BEGIN

	-- Return the result of the function
	RETURN @Principal * @Rate * @Time

END
GO

-- Executing above function

SELECT dbo.fudf_SimpleInterestCalc(1000, 20, 5) AS RESULT

-- Clean up:

ALTER TABLE [EmployeeDetails]
DROP CONSTRAINT [PK_EmployeeDetails]

DROP PROCEDURE usp_GetEmployeeDetails
DROP PROCEDURE usp_AddEmployeeDetails

DROP FUNCTION fudf_GetEmployeesDetails
DROP FUNCTION fudf_SimpleInterestCalc

DROP TABLE [EmployeeDetails]
