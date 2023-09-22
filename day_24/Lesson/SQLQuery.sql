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

INSERT INTO ABC_Shipping_Co(FullName, Phone, Email, Address, AptOrSuite, PostalZip, Country)
VALUES
	('Neville Mccullough','(836) 438-5807','sapien.imperdiet@outlook.couk','1528 Arcu. Rd.','São Paulo','388737','Mexico'),
	('Drake Swanson','1-842-473-3773','et.rutrum@outlook.couk','454-8489 Laoreet Av.','Gyeonggi','2697','Philippines'),
	('Aspen Phillips','(744) 825-4421','ultrices@aol.edu','Ap #651-1787 Libero Av.','San José','76461','Belgium'),
	('Nash Molina','(815) 330-3084','nec.ante@hotmail.edu','Ap #221-5295 Dictum Rd.','Southwestern Tagalog Region','494219','Philippines'),
	('Britanney Bryant','(541) 333-8677','sem.magna@icloud.org','469-7677 Diam. Road','Kogi','76980-37803','China'),
	('Zelenia Booker','1-516-986-6385','vel.vulputate@google.edu','963 Imperdiet Avenue','Lviv oblast','392076','United States'),
	('Keane Dodson','1-747-596-2358','vivamus.molestie@google.edu','Ap #316-1298 Blandit Road','Nova Scotia','Y7T 9J8','Canada'),
	('Remedios Taylor','1-542-539-6667','duis.cursus@outlook.org','P.O. Box 237, 2774 Vivamus Avenue','Central Sulawesi','51214','Indonesia'),
	('Yuli Velasquez','1-741-250-2138','interdum@yahoo.org','833-350 Donec Av.','Huáběi','275771','China'),
	('Kristen Lynn','1-661-476-8145','morbi.quis.urna@aol.com','Ap #566-9496 Egestas Rd.','Gilgit Baltistan','8727 PM','United States'),
	('Jason Talley','(277) 744-6844','neque.vitae@outlook.ca','341-821 Sem St.','East Region','420758','Canada'),
	('Jackson Burgess','(591) 631-6315','lorem@aol.ca','Ap #328-8365 A St.','Cantabria','6259','South Korea')

SELECT * FROM ABC_Shipping_Co

-- Clean up:


DROP TABLE ABC_Shipping_Co