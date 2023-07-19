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

-- TEMPLATE for a Store Procedure:
/*
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

-- Pre-built / System functions:

SELECT SUM(ID) [SUM] FROM [EmployeeDetails]

-- User defined functions:

-- 1. Inline Table-valued Functions:

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

-- 2. Multi-statement Table-valued Function:

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

-- 3. Scalar-valued Function:

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
