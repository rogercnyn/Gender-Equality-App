CREATE TABLE RegistrationData (userID INT primary key identity (1,1), userName VARCHAR (50), userPassword VARCHAR (50), firstName VARCHAR (50), middleName VARCHAR (50), lastName VARCHAR (50), gender VARCHAR (50), emailAddress VARCHAR (50), Birthday SMALLDATETIME);

ALTER TABLE RegistrationData
ALTER COLUMN Birthday VARCHAR(50);

SELECT * FROM RegistrationData;