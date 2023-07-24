Use MyLocalDb;

CREATE TABLE ABC_Shipping_Co (
	ID int NOT NULL IDENTITY(1,1),
	FullName varchar(256),
	Phone varchar(15),
	Email varchar(50),
	Address varchar(256),
	AptOrSuite varchar(50),
	PostalZip varchar(15),
	Country varchar(50),
	CONSTRAINT [PK_ABC_Shipping_Company] PRIMARY KEY (ID)
)

SELECT * FROM ABC_Shipping_Co

-- Clean up:

--DELETE FROM ABC_Shipping_Co WHERE ID = 4;


DROP TABLE ABC_Shipping_Co