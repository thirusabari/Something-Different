IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='UserLoginInfo')
BEGIN
CREATE TABLE UserLoginInfo(
	UserId INT IDENTITY PRIMARY KEY NOT NULL,
	EmailId NVARCHAR(100) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	LogInTime DATETIME NOT NULL,
	LogOutTime DATETIME NULL,
	CreatedBy VARCHAR(200) NOT NULL,
	CreatedDate DATETIME NOT NULL,
	ModifiedBy VARCHAR(200) NULL,
	ModifiedDate DATETIME NULL
);
END
GO
IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='IDCardDetails')
BEGIN
CREATE TABLE IDCardDetails(
	CardId INT IDENTITY PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	Gender VARCHAR(1) NOT NULL,
	BloodGroup VARCHAR(30) NOT NULL,
	Address1 VARCHAR(max) NOT NULL,
	Address2 VARCHAR(max) NULL,
	Address3 VARCHAR(max) NULL,
	City VARCHAR(30) NOT NULL,
	ZipCode VARCHAR(25) NOT NULL,
	PhoneNumber1 BIGINT NOT NULL CHECK  (PhoneNumber1 between 0 AND 9999999999),
	PhoneNumber2 BIGINT NULL CHECK  (PhoneNumber2 between 0 AND 9999999999),
	IsEmployee BIT NULL,
	IsStudent BIT NULL,
	CreatedBy VARCHAR(200) NOT NULL,
	CreatedDate DATETIME NOT NULL,
	ModifiedBy VARCHAR(200) NULL,
	ModifiedDate DATETIME NULL
);
END
GO
IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='StudentIDInfo')
BEGIN
CREATE TABLE StudentIDInfo(
	StudentId INT IDENTITY PRIMARY KEY NOT NULL,
	CardId INT FOREIGN KEY (CardId) REFERENCES IDCardDetails(CardId) NOT NULL ,
	StudentName VARCHAR(50) NOT NULL,
	Grade VARCHAR(40)  NOT NULL,
	SchoolName NVARCHAR(MAX) NOT NULL,
	CreatedBy VARCHAR(200) NOT NULL,
	CreatedDate DATETIME NOT NULL,
	ModifiedBy VARCHAR(200) NULL,
	ModifiedDate DATETIME NULL,
);
END
GO
IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='EmployeeIDInfo')
BEGIN
CREATE TABLE EmployeeIDInfo(
	EmpId INT IDENTITY PRIMARY KEY NOT NULL,
	CardId INT FOREIGN KEY (CardId) REFERENCES IDCardDetails(CardId) NOT NULL ,
	EmployeeName VARCHAR(50) NOT NULL,
	EmployeeCode VARCHAR(40) NOT NULL,
	CompanyName NVARCHAR(MAX) NOT NULL,
	CreatedBy VARCHAR(200) NOT NULL,
	CreatedDate DATETIME NOT NULL,
	ModifiedBy VARCHAR(200) NULL,
	ModifiedDate DATETIME NULL
);
END
GO

