-- Day 21 Assignment:

CREATE TABLE FEDEX_Customers (
	FEDEX_CustomersID int NOT NULL,
	Name varchar(50),
	Phone varchar(50),
	Email varchar(50),
	Address varchar(50),
	Country varchar(50),
	Region varchar(50),
	PostalZip varchar(20),
	CONSTRAINT [PK_FEDEX_Customers] PRIMARY KEY CLUSTERED (FEDEX_CustomersID)
)

INSERT INTO FEDEX_Customers (FEDEX_CustomersID, Name, Phone, Email, Address, Country, Region, PostalZip)
VALUES
	(1, 'Demetria Odom', '(559) 224-5775', 'dolor.nonummy@hotmail.edu', 'P.O. Box 337, 1799 Sed Street', 'Philippines', 'Hamburg', '359612'),
	(2, 'Trevor Meyers', '(607) 929-3515', 'blandit@protonmail.couk', 'P.O. Box 978, 4465 Elit. Ave', 'Peru', 'Huáběi', 'Y1A 7K5'),
	(3, 'Keegan Craig', '(410) 731-1761', 'cum@outlook.couk', '152-6608 Orci Street', 'Colombia', 'Biobío', '42808-26523'),
	(4, 'Macaulay Pittman', '(645) 220-2636', 'senectus.et@hotmail.edu', '637-2951 Lacus. Avenue', 'Chile', 'Valle d''Aosta', '555325'),
	(5, 'Orlando Wright', '1-196-667-2884', 'lorem.tristique.aliquet@hotmail.edu', '645-2503 Mi St.', 'Russian Federation', 'Huáběi', '345854')

CREATE TABLE UPS_Customers (
    UPS_CustomersID INTEGER NOT NULL,
	Name varchar(50),
	Phone varchar(50),
	Email varchar(50),
	Address varchar(50),
	Country varchar(50),
	Region varchar(50),
	PostalZip varchar(20),
    CONSTRAINT [PK_UPS_Customers] PRIMARY KEY CLUSTERED (UPS_CustomersID)
)

INSERT INTO [UPS_Customers] (UPS_CustomersID, Name, Phone, Email, Address, Country, Region, PostalZip)
VALUES
	(1, 'Beatrice Snow', '(375) 378-2776', 'sed.orci.lobortis@hotmail.net', '942-7872 Aliquet, Street', 'Pakistan', 'Niedersachsen', '3123'),
	(2, 'Drew Knowles', '1-345-128-3236', 'donec.elementum@icloud.com', '8266 Massa. Avenue', 'Spain', 'Friesland', '2741'),
	(3, 'Colby Hewitt', '1-477-480-8634', 'fusce.aliquam@icloud.ca', '358-7037 Aliquet Ave', 'France', 'Castilla - La Mancha', '5210'),
	(4, 'Jerry Holloway', '(883) 142-2467', 'mauris@protonmail.net', 'P.O. Box 375, 4203 Volutpat. Rd.', 'Mexico', 'Arequipa', '358009'),
	(5, 'Asher Mcmahon', '1-458-228-5086', 'luctus.lobortis.class@aol.ca', '960-6613 Nunc St.', 'Russian Federation', 'Northwest Territories', '849547')


-- Store Procedures:

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Author:		Ashik Khulal
-- Create date: 07/19/2023
-- Description:	Gets data from tables
-- ==========================================================================================
CREATE PROCEDURE usp_GetCustomerDetails
	@Table_Name varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	EXEC ('SELECT * FROM ' + @Table_Name)
END
GO

-- Executing above store procedure (displays data)
EXEC usp_GetCustomerDetails FEDEX_Customers
EXEC usp_GetCustomerDetails UPS_Customers

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Author:		Ashik Khulal
-- Create date: 07/19/2023
-- Description:	Adds data into tables with choices. 1 for FEDEX_Customers and 2 for UPS_Customers.
-- ==========================================================================================
ALTER PROCEDURE usp_AddCustomerDetails
	@Choice varchar(20),
	@ID int,
	@Name varchar(50),
	@Phone varchar(50),
	@Email varchar(50),
	@Address varchar(50),
	@Country varchar(50),
	@Region varchar(50),
	@PostalZip varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	IF @Choice = 1
		INSERT INTO FEDEX_Customers VALUES (@ID, @Name, @Phone, @Email, @Address, @Country, @Region, @PostalZip)
	ELSE IF @Choice = 2
		INSERT INTO UPS_Customers VALUES (@ID, @Name, @Phone, @Email, @Address, @Country, @Region, @PostalZip)
END
GO

-- Executing above store procedure (adding data)
EXEC usp_AddCustomerDetails 1, 6, "Chloe Barker", "(831) 484-5424", "blandit.mattis@hotmail.couk", "Ap #517-7145 Augue Avenue", "7576", "Diyarbakır", "Colombia"
EXEC usp_AddCustomerDetails 2, 6, "Cruz Miles", "(705) 236-8755", "interdum.feugiat.sed@icloud.com", "353-8293 Integer Rd.", "7417", "Zachodniopomorskie", "Austria"
EXEC usp_AddCustomerDetails 1, 7, "Eagan Cantu", "(597) 938-1366", "donec.egestas@icloud.net", "698-4982 Scelerisque St.", "60784-469", "Oregon", "Costa Rica"
EXEC usp_AddCustomerDetails 2, 7, "Debra Dyer", "1-627-822-3687", "mi.lorem.vehicula@yahoo.couk", "437-6534 Metus. Road", "2485", "Quebec", "South Korea"
EXEC usp_AddCustomerDetails 1, 8, "Branden Vasquez", "1-722-638-3877", "curabitur.egestas@google.net", "7324 Id St.", "2767", "Castilla - La Mancha", "Poland"
EXEC usp_AddCustomerDetails 2, 8, "Branden Vasquez", "1-722-638-3877", "curabitur.egestas@google.net", "7324 Id St.", "2767", "Castilla - La Mancha", "Poland"

-- Executing above store procedure (displays data)
EXEC usp_GetCustomerDetails FEDEX_Customers
EXEC usp_GetCustomerDetails UPS_Customers

-- Functions:

-- System Functions:

-- String Functions:

-- ASCII(): returns the ASCII value for the specific character.
-- SYNTAX: 
-- ASCII(character)

SELECT Name, ASCII(Name) AS NumCodeOfFirstChar FROM FEDEX_Customers
SELECT Name, ASCII(Name) AS NumCodeOfFirstChar FROM UPS_Customers

-- CHAR(): returns the character based on the ASCII code
-- SYNTAX: 
-- CHAR(code)

SELECT CHAR(66)  AS CodeToCharacter
SELECT CHAR(68)  AS CodeToCharacter
SELECT CHAR(66)  AS CodeToCharacter
SELECT Name, ASCII(Name) AS NumCodeOfFirstChar, CHAR(ASCII(Name)) AS CodeToCharacter FROM FEDEX_Customers

-- CHARINDEX(): searches for a substring in a string, and returns the position. If the substring is not found, this function returns 0. This function performs a case-insensitive search.
-- SYNTAX:
-- CHARINDEX(substring, string, start)

SELECT CHARINDEX('a', 'Elephant') AS MatchPosition

-- CONCAT(): adds two or more strings together.
-- SYNTAX:
-- CONCAT(string1, string2, ...., string_n)

SELECT CONCAT('APPLE', ' ', 'BOTTOM', ' ', 'JEANS') AS Combined_Text
SELECT CONCAT('SQL', ' is', ' fun!')

-- Or concat with +:
SELECT 'SQL' + ' is' + ' fun!'
SELECT 'SQL' + ' ' + 'is' + ' ' + 'fun!'

--  CONCAT_WS(): adds two or more strings together with a separator.
-- SYNTAX:
-- CONCAT_WS(separator, string1, string2, ...., string_n)

SELECT CONCAT_WS('-', 'APPLE', 'BOTTOM', 'JEANS') AS Combined_Text
SELECT CONCAT_WS(' ', 'SQL', 'is', 'fun!')

-- DATALENGTH(): returns the number of bytes used to represent an expression.
-- SYNTAX:
-- DATALENGTH(expression)

SELECT DATALENGTH('APPLE-BOTTOM-JEANS')

-- DIFFERENCE(): compares two SOUNDEX values, and returns an integer. The integer value indicates the match for the two SOUNDEX values, from 0 to 4. 0 indicates weak or no similarity between the SOUNDEX values. 4 indicates strong similarity or identically SOUNDEX values.
-- SYNTAX:
-- DIFFERENCE(expression, expression)

SELECT DIFFERENCE('Yes', 'YES')

-- FORMAT(): formats a value with the specified format
-- SYNTAX:
-- FORMAT(value, format, culture)

DECLARE @d DATE = '07/19/2023'
SELECT FORMAT(@d, 'd', 'en-US') AS 'US English Result'
SELECT FORMAT(@d, 'd', 'no') AS 'Norwegian Result'
SELECT FORMAT(@d, 'd', 'zu') AS 'Zulu Result'

SELECT FORMAT(1234567890, '###-###-####');

-- LEFT(): extracts a number of characters from a string (starting from left)
-- SYNTAX:
-- LEFT(string, number_of_chars)

SELECT LEFT('Microsoft SQL Server', 9) AS ExtractString

-- LEN(): returns the length of a string
-- SYNTAX:
-- LEN(string)

SELECT LEN('Hello World') AS TextLength

-- LOWER(): converts a string to lower-case 
-- SYNTAX:
-- LOWER(text)

SELECT LOWER('SQL IS FUN!')

-- LTRIM(): removes leading spaces from a string
-- SYNTAX:
-- LTRIM(string)

SELECT LTRIM('     SQL World') AS LeftTrimmedString;

-- NCHAR(): returns the Unicode character based on the number code
-- SYNTAX:
-- NCHAR(number_code)

SELECT NCHAR(65) AS NumberCodeToUnicode;
SELECT CHAR(65) AS NumberCodeToUnicode;

-- PATINDEX(): returns the position of a pattern in a string
-- SYNTAX:
-- PATINDEX(%pattern%, string)

SELECT PATINDEX('%BOTTOM%', 'APPLE-BOTTOM-JEANS')

-- QUOTENAME(): returns a Unicode string with delimiters added to make the string a valid SQL Server delimited identifier
-- SYNTAX:
-- QUOTENAME(string, quote_char)

SELECT QUOTENAME('abcdef');

-- REPLACE(): replaces all occurrences of a substring within a string, with a new substring
-- SYNTAX:
-- REPLACE(string, old_string, new_string)

SELECT REPLACE('SQL Took The World', 'T', 'M')

-- REPLICATE(): repeats a string a specified number of times
-- SYNTAX:
-- REPLICATE(string, integer)

SELECT REPLICATE('Boom ', 4)

-- REVERSE(): reverses a string and returns the result
-- SYNTAX:
-- REVERSE(string)

SELECT REVERSE('ASHIK')
SELECT REVERSE('KAYAK')
SELECT REVERSE('ROTATOR')
SELECT REVERSE('KHULAL')
SELECT REVERSE('WOW')
SELECT REVERSE('IRVING')
SELECT REVERSE('RACECAR')

-- RIGHT(): extracts a number of characters from a string (starting from right)
-- SYNTAX:
-- RIGHT(string, number_of_chars)

SELECT RIGHT('Hello World!', 6)

-- RTRIM(): removes trailing spaces from a string
-- SYNTAX:
-- RTRIM(string)

SELECT RTRIM('Hello World! ') AS RightTrimmedString

-- SOUNDEX(): returns a four-character code to evaluate the similarity of two expressions. The SOUNDEX() converts the string to a four-character code based on how the string sounds when spoken.
-- SYNTAX:
-- SOUNDEX(expression)

SELECT SOUNDEX('Juice'), SOUNDEX('Jucy')
SELECT SOUNDEX('Hello'), SOUNDEX('Yello')
SELECT SOUNDEX('Juice'), SOUNDEX('Banana')

-- SPACE(): returns a string of the specified number of space characters
-- SYNTAX:
-- SPACE(number)

SELECT SPACE(10)
SELECT 'Hello' + SPACE(1) + 'World!'

-- STR(): returns a number as a string
-- SYNTAX:
-- STR(number, length, decimals)

SELECT STR(185);

-- STUFF(): deletes a part of a string and then inserts another part into the string, starting at a specified position
-- SYNTAX:
-- STUFF(string, start, length, new_string)

SELECT STUFF('SQL World', 1, 3, 'HTML')
SELECT STUFF('Monkey King', 1, 11, 'Kingkong')

-- SUBSTRING(): extracts some characters from a string
-- SYNTAX:
-- SUBSTRING(string, start, length)

SELECT SUBSTRING('SQL World', 1, 3)
SELECT SUBSTRING('Ashik Khulal', 1, 5)

-- TRANSLATE(): returns the string from the first argument after the characters specified in the second argument are translated into the characters specified in the third argument. The TRANSLATE() function will return an error if characters and translations have different lengths.
-- SYNTAX:
-- TRANSLATE(string, characters, translations)

SELECT TRANSLATE('Monday', 'Monday', 'Sunday')
SELECT TRANSLATE('ABC DEF', 'ABC', '123')

-- TRIM(): removes the space character OR other specified characters from the start or end of a string. By default, the TRIM() function removes leading and trailing spaces from a string.
-- SYNTAX:
-- TRIM([characters FROM ]string)

SELECT TRIM('     SQL World!     ') AS TrimmedString

-- UNICODE(): returns an integer value (the Unicode value), for the first character of the input expression
-- SYNTAX:
-- UNICODE(character_expression)

SELECT UNICODE('Atlanta')
SELECT UNICODE('Texas')

-- UPPER(): converts a string to upper-case
-- SYNTAX:
-- UPPER(text)

SELECT UPPER('sql is fun!')

-- Numeric Functions:

-- ABS(): returns the absolute value of a number
-- SYNTAX:
-- ABS(number)

SELECT Abs(-243.5) AS AbsNum

-- ACOS(): returns the arc cosine of a number. The specified number must be between -1 to 1, otherwise this function returns NULL. 
-- SYNTAX:
-- ACOS(number)

SELECT ACOS(0.25)

-- ASIN(): returns the arc sine of a number. The specified number must be between -1 to 1, otherwise this function returns NULL. 
-- SYNTAX:
-- ASIN(number)

SELECT ASIN(0.25)

-- ATAN(): returns the arc tangent of a number.
-- SYNTAX:
-- ATAN(number)

SELECT ATAN(2.5)

-- ATN2(): returns the arc tangent of two numbers
-- SYNTAX:
-- ATN2(a, b)

SELECT ATN2(0.50, 1)

-- AVG(): returns the average value of an expression
-- SYNTAX:
-- AVG(expression)

SELECT AVG(FEDEX_CustomersID) AS Avg_FEDEX_CustomersID FROM FEDEX_Customers

-- CEILING(): returns the smallest integer value that is larger than or equal to a number
-- SYNTAX:
-- CEILING(number)

SELECT CEILING(25.75) AS CeilValue

-- COUNT(): returns the number of records returned by a select query. NULL values are not counted
-- SYNTAX:
-- COUNT(expression)

SELECT COUNT(FEDEX_CustomersID) AS Count_FEDEX_CustomersID FROM FEDEX_Customers

-- COS(): returns the cosine of a number
-- SYNTAX:
-- COS(number)

SELECT COS(2)

-- COT(): returns the cotangent of a number
-- SYNTAX:
-- COT(number)

SELECT COT(6)

-- DEGREES(): converts a value in radians to degrees
-- SYNTAX:
-- DEGREES(number)

SELECT DEGREES(1.5)

-- EXP(): returns e raised to the power of a specified number
-- SYNTAX:
-- EXP(number)

SELECT EXP(1)

-- FLOOR(): returns the largest integer value that is smaller than or equal to a number
-- SYNTAX:
-- FLOOR(number)

SELECT FLOOR(25.75) AS FloorValue

-- LOG(): returns the natural logarithm of a specified number, or the logarithm of the number to the specified base
-- SYNTAX:
-- LOG(number, base)

SELECT LOG(2)

-- LOG10() function returns the natural logarithm of a number to base 10
-- SYNTAX:
-- LOG10(number)

SELECT LOG10(2)

-- MAX(): returns the maximum value in a set of values
-- SYNTAX:
-- MAX(expression)

SELECT MAX(FEDEX_CustomersID) AS LargestID FROM FEDEX_Customers

-- MIN(): returns the minimum value in a set of values
-- SYNTAX:
-- MIN(expression)

SELECT MIN(FEDEX_CustomersID) AS LargestID FROM FEDEX_Customers

-- PI(): returns the value of PI
-- SYNTAX:
-- PI()

SELECT PI()

-- POWER(): returns the value of a number raised to the power of another number
-- SYNTAX:
-- POWER(a, b)

SELECT POWER(2,2)

-- RADIANS(): converts a degree value into radians.
-- SYNTAX:
-- RADIANS(number)

SELECT RADIANS(180)

-- RAND(): returns a random number between 0 (inclusive) and 1 (exclusive)
-- SYNTAX:
--RAND(seed)

SELECT RAND()

-- ROUND(): rounds a number to a specified number of decimal places
-- SYNTAX:
-- ROUND(number, decimals, operation)

SELECT ROUND(235.415, 2) AS RoundValue

-- The SIGN(): returns the sign of a number.
/* 
This function will return one of the following:
If number > 0, it returns 1
If number = 0, it returns 0
If number < 0, it returns -1
*/
-- SYNTAX:
-- SIGN(number)

SELECT SIGN(255.5)

-- SIN(): returns the sine of a number
-- SYNTAX:
-- SIN(number)

SELECT SIN(2)

-- SQRT(): returns the square root of a number
-- SYNTAX:
-- SQRT(number)

SELECT SQRT(64)

-- SQUARE(): returns the square of a number
-- SYNTAX:
-- SQUARE(number)

SELECT SQUARE(4)

-- SUM(): calculates the sum of a set of values
-- SYNTAX:
-- SUM(expression)

SELECT SUM(FEDEX_CustomersID) AS SUMID FROM FEDEX_Customers

-- TAN(): returns the tangent of a number
-- SYNTAX:
-- TAN(number)

SELECT TAN(1.75)

-- Date Functions:

-- CURRENT_TIMESTAMP: returns the current date and time, in a 'YYYY-MM-DD hh:mm:ss.mmm' format
-- SYNTAX:
-- CURRENT_TIMESTAMP

SELECT CURRENT_TIMESTAMP

-- DATEADD() adds a time/date interval to a date and then returns the date
-- SYNTAX:
-- DATEADD(interval, number, date)

SELECT DATEADD(year, 1, '1995/08/01') AS DateAdd

-- DATEDIFF(): returns the difference between two dates
-- SYNTAX:
-- DATEDIFF(interval, date1, date2)

SELECT DATEDIFF(year, '1995/08/01', '2023/08/01') AS DateDiff

-- DATEFROMPARTS(): returns a date from the specified parts (year, month, and day values)
-- SYNTAX:
-- DATEFROMPARTS(year, month, day)

SELECT DATEFROMPARTS(2018, 10, 31) AS DateFromParts

-- DATENAME(): returns a specified part of a date
-- SYNTAX:
-- DATENAME(interval, date)

SELECT DATENAME(year, '2017/08/25') AS DatePartString

-- DATEPART(): returns a specified part of a date. This function returns the result as an integer value.
-- SYNTAX:
-- DATEPART(interval, date)

SELECT DATEPART(year, '2017/08/25') AS DatePartInt

-- DAY(): returns the day of the month (from 1 to 31) for a specified date
-- SYNTAX:
-- DAY(date)

SELECT DAY('2017/08/25') AS DayOfMonth

-- GETDATE(): returns the current database system date and time, in a 'YYYY-MM-DD hh:mm:ss.mmm' format
-- SYNTAX:
-- GETDATE()

SELECT GETDATE()

-- GETUTCDATE(): returns the current database system UTC date and time, in a 'YYYY-MM-DD hh:mm:ss.mmm' format
-- SYNTAX:
-- GETUTCDATE()

SELECT GETUTCDATE()

-- ISDATE(): checks an expression and returns 1 if it is a valid date, otherwise 0
-- SYNTAX:
-- ISDATE(expression)

SELECT ISDATE('2017-08-25')
SELECT ISDATE('2017-13-25')

-- MONTH(): returns the month part for a specified date (a number from 1 to 12)
-- SYNTAX:
-- MONTH(date)

SELECT MONTH('2017-08-25') AS Month

-- SYSDATETIME(): returns the date and time of the computer where the SQL Server is running
-- SYNTAX:
-- SYSDATETIME()

SELECT SYSDATETIME() AS SysDateTime

-- YEAR(): returns the year part for a specified date
-- SYNTAX:
-- YEAR(date)

SELECT YEAR('2017/08/25') AS Year

-- Advanced Functions:

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- 
-- SYNTAX:
-- 

-- User Defined Functions:


-- Clean up:

ALTER TABLE FEDEX_Customers
DROP CONSTRAINT [PK_FEDEX_Customers]

ALTER TABLE UPS_Customers
DROP CONSTRAINT [PK_UPS_Customers]

DROP PROCEDURE usp_GetCustomerDetails
DROP PROCEDURE usp_AddCustomerDetails

DROP TABLE FEDEX_Customers
DROP TABLE UPS_Customers
