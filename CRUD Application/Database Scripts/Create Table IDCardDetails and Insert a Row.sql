IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='IDCardDetails')
BEGIN
CREATE TABLE IDCardDetails(
	CardId INT IDENTITY PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	Gender VARCHAR(1) NOT NULL,
	Address1  VARCHAR(max) NOT NULL,
	Address2 VARCHAR(max) NOT NULL,
	Address3 VARCHAR(max) NOT NULL,
	City VARCHAR(30) NOT NULL,
	PhoneNumber BIGINT NOT NULL CHECK  (PhoneNumber between 0 AND 9999999999),
	ZipCode VARCHAR(25) NOT NULL
);
END
GO
IF NOT EXISTS(SELECT * FROM IDCardDetails)
BEGIN
INSERT INTO IDCardDetails([Name],Gender,Address1,Address2,Address3,City,PhoneNumber,ZipCode)
VALUES('Creator','M','Patent Street','Inventions Zone','Ideas District','SomethingDifferent',9834657321,'SM1001')
END
GO