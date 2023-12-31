-- # Day 19 Assignment:

USE MyLocalDb;

-- # Create two tables:
CREATE TABLE [TEXAS](
	[TX_ID] [int] NOT NULL,
	[CITY_NAME] [nvarchar](50),
	[TOTAL_POPULATION] [bigint],
	[AREA_IN_SQ_MILES] [decimal](18,2),
	[TX_RANK] [int] NOT NULL,
	[CREATED_DATE] [datetime]);

CREATE TABLE [CALIFORNIA](
	[CA_ID] [int] NOT NULL,
	[CITY_NAME] [nvarchar](50),
	[TOTAL_POPULATION] [bigint],
	[AREA_IN_SQ_MILES] [decimal](18,2),
	[CA_RANK] [int] NOT NULL,
	[CREATED_DATE] [datetime]);

-- # Adding primary keys:
ALTER TABLE [TEXAS] 
ADD CONSTRAINT [PK_TEXAS] PRIMARY KEY CLUSTERED (TX_ID);

ALTER TABLE [CALIFORNIA] 
ADD CONSTRAINT [PK_CALIFORNIA] PRIMARY KEY CLUSTERED (CA_ID);

-- # Adding few datas:
INSERT INTO [TEXAS]
    ([TX_ID], [CITY_NAME], [TOTAL_POPULATION], [AREA_IN_SQ_MILES], [TX_RANK], [CREATED_DATE])
VALUES 
    (1, 'Houston', 2264876, 640.19, 1, GETDATE()),
    (2, 'San Antonio', 1479493, 485.11, 2, GETDATE()),
    (3, 'Dallas', 1259404, 339.74, 3, GETDATE()),
    (4, 'Austin', 966292, 319.94, 4, GETDATE()),
    (5, 'Fort Worth', 961885, 345.58, 5, GETDATE());

INSERT INTO [CALIFORNIA]
    ([CA_ID], [CITY_NAME], [TOTAL_POPULATION], [AREA_IN_SQ_MILES], [CA_RANK], [CREATED_DATE])
VALUES 
    (1, 'Los Angeles', 3769485, 468.96, 1, GETDATE()),
    (2, 'San Diego', 1374076, 325.88, 2, GETDATE()),
    (3, 'San Jose', 1374076, 325.88, 3, GETDATE()),
    (4, 'San Francisco', 715717, 46.90, 4, GETDATE()),
    (5, 'Fresno', 549242, 114.72, 5, GETDATE());

-- # Adding foreign keys with set on delete and update (no action) anamolies:
ALTER TABLE [TEXAS] 
ADD CONSTRAINT [FK_TEXAS] 
FOREIGN KEY (TX_RANK) REFERENCES CALIFORNIA(CA_ID)
ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE [CALIFORNIA] 
ADD CONSTRAINT [FK_CALIFORNIA] 
FOREIGN KEY (CA_RANK) REFERENCES TEXAS(TX_ID)
ON DELETE NO ACTION ON UPDATE NO ACTION;

-- # Display data:
SELECT * FROM [TEXAS];
SELECT * FROM [CALIFORNIA];


--Clean up:

-- # Droping foreign keys:
ALTER TABLE [TEXAS] 
DROP CONSTRAINT [FK_TEXAS];

ALTER TABLE [CALIFORNIA] 
DROP CONSTRAINT [FK_CALIFORNIA];

-- # Droping primary keys:
ALTER TABLE [TEXAS] 
DROP CONSTRAINT [PK_TEXAS];

ALTER TABLE [CALIFORNIA] 
DROP CONSTRAINT [PK_CALIFORNIA];

-- # Dropping tables:
DROP TABLE [TEXAS];
DROP TABLE [CALIFORNIA];
