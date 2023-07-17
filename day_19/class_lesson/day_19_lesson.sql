/*
Day 19 class topics:
1. Primary key
2. Unique key
3. Composite key
4. Foreign key
*/

USE MyLocalDb;

CREATE TABLE [day_19_table](
	[ID] [bigint] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_day_19_table] PRIMARY KEY CLUSTERED (ID));


 INSERT INTO [day_19_table]
    ([ID], [FirstName], [LastName], [Address], [UpdatedDate])
VALUES 
    (1, 'CHIN', 'YEN', '123 LAB ASSISTANT ST', GETDATE()),
    (2, 'MIKE', 'PEARL', 'XYZ SENIOR ACCOUNTANT DR', GETDATE()),
    (3, 'GREEN', 'FIELD', 'ABC ACCOUNTANT CIR', GETDATE()),
    (4, 'DEWANE', 'PAUL', '112 PROGRAMMER AVE', GETDATE()),
    (5, 'MATTS', 'SR.', '124 PROGRAMMER HWY', GETDATE()),
    (6, 'PLANK', 'OTO', '717 ACCOUNTANT FM RD', GETDATE());


SELECT * FROM [day_19_table];

--Deletes data from table
DELETE FROM [day_19_table];

--Refreshes table's schema
TRUNCATE TABLE [day_19_table];

--Drops table from a db
DROP TABLE [day_19_table];


--Adding primary key later
ALTER TABLE [day_19_table] 
ADD CONSTRAINT [PK_day_19_table] PRIMARY KEY CLUSTERED (ID);

--Rebuilding primary key index
ALTER INDEX [PK_day_19_table] ON [day_19_table]
REBUILD;

--Disabling primary key index
ALTER INDEX [PK_day_19_table] ON [day_19_table]
DISABLE;

--Droping primary key index
ALTER TABLE [day_19_table] 
DROP CONSTRAINT [PK_day_19_table];

--Unique key allows entry of null values as a unique value unlike primary key

--Composite key: combination of columns as a indexs and adding them together for a primary key