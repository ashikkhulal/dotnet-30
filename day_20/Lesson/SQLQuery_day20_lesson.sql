/*
Day 20 topics:
1. SQL Views
2. SQL Joins
*/

USE MyLocalDb;

CREATE TABLE EMPLOYEE_APPLE(
	APPLE_ID [int] NOT NULL,
	FIRST_NAME [nvarchar](50),
	LAST_NAME [nvarchar](50),
	SALARY [decimal](18,2),
	JOB_TITLE [nvarchar](50),
	ENTRY_DATE [datetime],
	CONSTRAINT [PK_EMPLOYEE_APPLE] PRIMARY KEY CLUSTERED (APPLE_ID));

INSERT INTO EMPLOYEE_APPLE
    (APPLE_ID, FIRST_NAME, LAST_NAME, SALARY, JOB_TITLE, ENTRY_DATE)
VALUES 
    (1, 'CHIN', 'YEN', 145000.00, 'LAB ASSISTANT', GETDATE()),
    (2, 'MIKE', 'PEARL', 170000.00, 'SR. ACCOUNTANT', GETDATE()),
    (3, 'GREEN', 'FIELD', 100000.00, 'ACCOUNTANT', GETDATE()),
    (4, 'DEWANE', 'PAUL', 150000.00, 'PROGRAMMER', GETDATE()),
    (5, 'MATTS', 'SR.', 150000.00, 'PROGRAMMER', GETDATE()),
    (6, 'PLANK', 'OTO', 100000.00, 'ACCOUNTANT', GETDATE()),
	(7, 'DEWANE', 'PAUL', 150000.00, 'PROGRAMMER', GETDATE()),
    (8, 'MATTS', 'JR.', 120000.00, 'JR. PROGRAMMER', GETDATE()),
    (9, 'PLANK', 'MOTTO', 170000.00, 'SR. ACCOUNTANT', GETDATE()),
	(10, 'PLANK', 'ONE', 100000.00, 'ACCOUNTANT', GETDATE());

CREATE TABLE EMPLOYEE_GOOGLE(
	GOOGLE_ID [int] NOT NULL,
	FIRST_NAME [nvarchar](50),
	LAST_NAME [nvarchar](50),
	SALARY [decimal](18,2),
	JOB_TITLE [nvarchar](50),
	ENTRY_DATE [datetime],
	CONSTRAINT [PK_EMPLOYEE_GOOGLE] PRIMARY KEY CLUSTERED (GOOGLE_ID));

INSERT INTO EMPLOYEE_GOOGLE
    (GOOGLE_ID, FIRST_NAME, LAST_NAME, SALARY, JOB_TITLE, ENTRY_DATE)
VALUES 
    (1, 'CHEN', 'YEN', 175000.00, 'SR. LAB ASSISTANT', GETDATE()),
    (2, 'HIKE', 'PEARL', 130000.00, 'ACCOUNTANT', GETDATE()),
    (3, 'BROWN', 'FIELD', 100000.00, 'JR. ACCOUNTANT', GETDATE()),
    (4, 'DEWANE', 'PAUL', 150000.00, 'PROGRAMMER', GETDATE()),
    (5, 'WATTS', 'SR.', 150000.00, 'PROGRAMMER', GETDATE()),
    (6, 'BURP', 'OTO', 100000.00, 'ACCOUNTANT', GETDATE()),
	(7, 'WYANE', 'PAUL', 150000.00, 'PROGRAMMER', GETDATE()),
    (8, 'MATTS', 'JR.', 120000.00, 'JR. PROGRAMMER', GETDATE()),
    (9, 'JOHN', 'MOTTO', 130000.00, 'SR. ACCOUNTANT', GETDATE()),
	(10, 'PLANK', 'ONE', 100000.00, 'JR. ACCOUNTANT', GETDATE());

--SQL Views: replica of the some or all of table(s) for data presentation

/*
In SQL, a view is a virtual table based on the result-set of an SQL statement.
A view contains rows and columns, just like a real table. The fields in a view are fields from one or more real tables in the database.
You can add SQL statements and functions to a view and present the data as if the data were coming from one single table.
A view is created with the CREATE VIEW statement.

SYNTAX:

CREATE VIEW view_name AS
SELECT column1, column2, ...
FROM table_name
WHERE condition;

- SQL Updating a View: A view can be updated with the CREATE OR REPLACE VIEW statement.

SYNTAX:

CREATE OR REPLACE VIEW view_name AS
SELECT column1, column2, ...
FROM table_name
WHERE condition;

- SQL Dropping a View: A view is deleted with the DROP VIEW statement.

SYNTAX:

DROP VIEW view_name;
*/

CREATE VIEW APPLE_FIVE_EMPLOYEE_DATA AS
SELECT TOP 5 * FROM EMPLOYEE_APPLE;

CREATE VIEW GOOGLE_FIVE_EMPLOYEE_DATA AS
SELECT TOP 5 * FROM EMPLOYEE_GOOGLE;

CREATE OR REPLACE VIEW APPLE_FIVE_EMPLOYEE_DATA AS
SELECT TOP 5 * FROM EMPLOYEE_APPLE;

CREATE OR REPLACE VIEW GOOGLE_FIVE_EMPLOYEE_DATA AS
SELECT TOP 5 * FROM EMPLOYEE_GOOGLE;

DROP VIEW APPLE_FIVE_EMPLOYEE_DATA;

DROP VIEW GOOGLE_FIVE_EMPLOYEE_DATA;

--returns number of rows as a count value
SELECT COUNT(*) FROM EMPLOYEE_APPLE;

--SQL Joins:
/*
A JOIN clause is used to combine rows from two or more tables, based on a related column between them.

Unmatched Join type(s):
- Cross join: also a raw join; simple multiplication of tables which are being joined

Matched Join type(s):
ON keyword is used to match the data
- Inner join: Returns records that have matching values in both tables

SYNTAX:

SELECT column_name(s)
FROM table1
INNER JOIN table2
ON table1.column_name = table2.column_name;

- We can add more inner join as necessary with on conditions.
*/

SELECT * FROM EMPLOYEE_APPLE INNER JOIN EMPLOYEE_GOOGLE ON EMPLOYEE_APPLE.APPLE_ID = EMPLOYEE_GOOGLE.GOOGLE_ID;

/*
- Outer join:
1. Left outer join: The LEFT JOIN keyword returns all records from the left table (table1), and the matching records from the right table (table2). The result is 0 records from the right side, if there is no match.

SYNTAX:

SELECT column_name(s)
FROM table1
LEFT JOIN table2
ON table1.column_name = table2.column_name;

2. Right outer join: The RIGHT JOIN keyword returns all records from the right table (table2), and the matching records from the left table (table1). The result is 0 records from the left side, if there is no match.

SYNTAX:

SELECT column_name(s)
FROM table1
RIGHT JOIN table2
ON table1.column_name = table2.column_name;

3. Full outer join: The FULL OUTER JOIN keyword returns all records when there is a match in left (table1) or right (table2) table records.

SYNTAX:

SELECT column_name(s)
FROM table1
FULL OUTER JOIN table2
ON table1.column_name = table2.column_name
WHERE condition;
*/

SELECT * FROM EMPLOYEE_APPLE LEFT JOIN EMPLOYEE_GOOGLE ON EMPLOYEE_APPLE.FIRST_NAME = EMPLOYEE_GOOGLE.FIRST_NAME;
SELECT * FROM EMPLOYEE_APPLE RIGHT JOIN EMPLOYEE_GOOGLE ON EMPLOYEE_APPLE.FIRST_NAME = EMPLOYEE_GOOGLE.FIRST_NAME;
SELECT * FROM EMPLOYEE_APPLE FULL JOIN EMPLOYEE_GOOGLE ON EMPLOYEE_APPLE.FIRST_NAME = EMPLOYEE_GOOGLE.FIRST_NAME;

/*
- Self join: A self join is a regular join, but the table is joined with itself.

SYNTAX:

SELECT column_name(s)
FROM table1 T1, table1 T2
WHERE condition;
*/
SELECT * FROM EMPLOYEE_APPLE EMPA1, EMPLOYEE_APPLE EMP2;

--Clean up:
ALTER TABLE EMPLOYEE_APPLE
DROP CONSTRAINT PK_EMPLOYEE_APPLE;

ALTER TABLE EMPLOYEE_GOOGLE
DROP CONSTRAINT PK_EMPLOYEE_GOOGLE;

DROP VIEW APPLE_FIVE_EMPLOYEE_DATA;
DROP VIEW GOOGLE_FIVE_EMPLOYEE_DATA;

DROP TABLE EMPLOYEE_APPLE;
DROP TABLE EMPLOYEE_GOOGLE;