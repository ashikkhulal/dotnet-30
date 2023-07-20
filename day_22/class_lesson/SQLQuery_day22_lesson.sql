Use MyLocalDb;

CREATE TABLE Employees (
	ID int NOT NULL IDENTITY(1,1),
	FirstName varchar(50),
	LastName varchar(50),
	Phone varchar(50),
	Email varchar(50),
	Address varchar(256),
	CONSTRAINT [PK_Employees] PRIMARY KEY (ID)
)

SELECT * FROM Employees