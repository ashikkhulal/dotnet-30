USE MyLocalDb;

CREATE TABLE Employee
    (EmpID INT NOT NULL , 
    EmpName VARCHAR(50) NOT NULL, 
    Designation VARCHAR(50) NULL, 
    Department VARCHAR(50) NULL, 
    JoiningDate DATETIME NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED (EmpID));

INSERT INTO Employee
    (EmpID, EmpName, Designation, Department, JoiningDate)
VALUES 
    (1, 'CHIN YEN', 'LAB ASSISTANT', 'LAB', GETDATE()),
    (2, 'MIKE PEARL', 'SENIOR ACCOUNTANT', 'ACCOUNTS', GETDATE()),
    (3, 'GREEN FIELD', 'ACCOUNTANT', 'ACCOUNTS', GETDATE()),
    (4, 'DEWANE PAUL', 'PROGRAMMER', 'IT', GETDATE()),
    (5, 'MATTS', 'SR. PROGRAMMER', 'IT', GETDATE()),
    (6, 'PLANK OTO', 'ACCOUNTANT', 'ACCOUNTS', GETDATE());

SELECT * FROM Employee;
