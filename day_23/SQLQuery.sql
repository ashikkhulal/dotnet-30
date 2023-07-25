Use MyLocalDb;

CREATE TABLE ABC_Shipping_Co (
	ID int NOT NULL IDENTITY(1,1),
	FullName varchar(256),
	Phone varchar(15),
	Email varchar(50),
	Address varchar(256),
	AptOrSuite varchar(50),
	PostalZip varchar(16),
	Country varchar(50),
	CONSTRAINT [PK_ABC_Shipping_Company] PRIMARY KEY (ID)
)

INSERT INTO ABC_Shipping_Co (FullName, Phone, Email, Address, AptOrSuite, PostalZip, Country)
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
	('Jackson Burgess','(591) 631-6315','lorem@aol.ca','Ap #328-8365 A St.','Cantabria','6259','South Korea'),
	('Oliver Knapp','1-752-503-9180','sapien.imperdiet@aol.org','Ap #362-5098 Turpis Road','Coquimbo','838726','Colombia'),
	('Arden Rice','1-626-289-3171','tristique@hotmail.org','P.O. Box 789, 6782 Sed Avenue','North Island','26882','Germany'),
	('Bertha Fuentes','1-477-385-2149','penatibus@aol.net','414-1015 Mauris Av.','Rio Grande do Sul','65-31','Poland'),
	('Geoffrey Mcclain','(549) 131-6111','phasellus.nulla@hotmail.couk','Ap #456-3482 Mi Rd.','Jönköpings län','309959','China'),
	('Myra Barnes','(886) 662-7559','luctus@google.net','Ap #196-6511 Faucibus St.','Principado de Asturias','08620','Philippines'),
	('Sarah Roman','1-465-780-5506','sit.amet@yahoo.couk','348-434 Posuere St.','Innlandet','4936','Italy'),
	('Kirsten Turner','(344) 668-3922','ornare.lectus@hotmail.couk','504-5013 Ipsum Road','South Island','17431','Sweden'),
	('Axel Walton','(124) 835-4481','nulla@yahoo.couk','Ap #137-9676 Risus. St.','Munster','30713','Nigeria'),
	('Ignatius Galloway','1-618-806-6851','mauris.nulla@outlook.net','630-3601 Egestas. Rd.','Drenthe','14382','China'),
	('Morgan Whitehead','(622) 478-4875','parturient.montes@outlook.couk','5474 Facilisis, Rd.','Southwestern Tagalog Region','83352','Brazil'),
	('Hayes Lopez','(451) 313-7544','arcu.curabitur.ut@yahoo.edu','P.O. Box 524, 868 Aliquam Avenue','Delta','10101','Russian Federation'),
	('Price Glover','(841) 878-5754','nulla@hotmail.edu','Ap #312-6542 Pede. Street','Lviv oblast','8051','Philippines'),
	('Jacqueline Benson','(214) 426-2849','cursus.et.magna@icloud.couk','Ap #774-8433 Auctor Ave','Northern Territory','75976','Peru'),
	('Olympia Baird','1-237-830-8448','vel@icloud.ca','704-446 Ac Road','Cartago','143849','Sweden'),
	('Stacy Travis','(659) 483-4162','ornare.lectus@outlook.couk','644-6661 Lobortis Ave','Haute-Normandie','23770','Turkey'),
	('Walker Atkins','(374) 338-4765','eu.nibh@icloud.edu','Ap #562-8924 Amet Rd.','Sinaloa','88031-759','Canada'),
	('Justin Willis','1-864-466-9594','nulla.aliquet.proin@protonmail.net','744-2601 Aenean Ave','Huáběi','447745','India'),
	('Gemma Mays','(391) 623-6489','mattis@aol.net','4233 Consectetuer St.','Jigawa','524937','Brazil'),
	('Dara Hines','1-613-654-1353','fringilla@aol.ca','660-2017 Sodales Rd.','Atlántico','881641','Peru'),
	('Ashton Drake','(390) 988-4432','libero.proin@outlook.org','Ap #957-105 Vivamus Ave','Sokoto','50113','Australia'),
	('Sydney Blevins','(369) 945-3621','cras.vulputate.velit@outlook.ca','Ap #771-3915 Blandit Road','Opolskie','53-52','Russian Federation'),
	('Ursa Barber','(742) 631-3287','dictum.sapien.aenean@protonmail.org','Ap #689-9914 Auctor Av.','Sinaloa','25677','Mexico'),
	('Dean Emerson','(553) 873-5961','vitae.diam.proin@protonmail.couk','P.O. Box 360, 9476 At, Rd.','Osun','5491','Singapore'),
	('Gloria Olsen','(627) 412-3935','risus@google.couk','4300 Eros. Road','Volgograd Oblast','3696','Ireland'),
	('Amena Bryan','1-344-550-1963','curabitur.vel.lectus@yahoo.org','9795 Justo Ave','North Maluku','888608','Austria'),
	('Talon Payne','1-235-663-1537','sed.auctor.odio@hotmail.org','Ap #476-2888 Vel Ave','Western Cape','54-93','Nigeria'),
	('Zena Haney','1-746-747-2681','facilisis@protonmail.couk','7620 Sed Ave','Coquimbo','6161','Ukraine'),
	('Martin Booker','(130) 251-1445','magna.lorem@hotmail.net','P.O. Box 602, 1786 Fringilla Rd.','Australian Capital Territory','8185','Spain'),
	('Ulysses Silva','1-319-615-5873','semper@yahoo.couk','P.O. Box 953, 6848 Quis St.','Munster','64046','Ireland'),
	('Abdul Kirk','1-353-312-5536','quisque.porttitor@icloud.edu','P.O. Box 467, 4469 Luctus, Street','Kansas','R5J 2W5','Turkey'),
	('Adrienne Martinez','1-943-437-5752','lorem.lorem.luctus@aol.net','4048 Felis St.','North Region','44695','Poland'),
	('Octavia Hester','(138) 572-5666','mollis.dui.in@icloud.net','Ap #880-8661 Proin Road','Nord-Pas-de-Calais','GL9 0VI','India'),
	('Tanya Stark','(215) 636-0337','nam.porttitor@aol.net','Ap #349-8699 Sociis Road','North Island','2760-2967','Mexico')


SELECT * FROM ABC_Shipping_Co
       

-- Clean up:


DROP TABLE ABC_Shipping_Co