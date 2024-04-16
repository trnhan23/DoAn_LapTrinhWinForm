CREATE TABLE [dbo].[Patients] (
    [patientsID]  VARCHAR (50)   NOT NULL,
    [fullName]    NVARCHAR (200) NULL,
    [gender]      NVARCHAR (10)  NULL,
    [birthDate]   DATE           NULL,
    [persionalID] VARCHAR (13)   NULL,
    [phoneNumber] VARCHAR (12)   NULL,
    [address]     NVARCHAR (255) NULL,
    [image] IMAGE NULL, 
    PRIMARY KEY CLUSTERED ([patientsID] ASC)
);
CREATE TABLE [dbo].[Users] (
    [userID]      VARCHAR (50)   NOT NULL,
    [fullName]    NVARCHAR (200) NULL,
    [birthDate]   DATE           NULL,
    [gender]      NVARCHAR (10)  NULL,
    [persionalID] VARCHAR (13)   NULL,
    [phoneNumber] VARCHAR (12)   NULL,
    [email]       VARCHAR (50)   NULL,
    [address]     NVARCHAR (255) NULL,
    [isRole]    NVARCHAR (50)  NULL,
    [password]    VARCHAR (12)   NULL,
    PRIMARY KEY CLUSTERED ([userID] ASC)
);
INSERT INTO [dbo].[Users] ([userID], [fullName], [birthDate], [gender], [persionalID], [phoneNumber], [email], [address], [isRole], [password])
VALUES ('yourUserID', N'Your Full Name', '1990-01-01', N'Male', '1234567890123', '1234567890', 'your.email@example.com', N'Your Address', N'User', 'yourpassword');


CREATE TABLE [dbo].[Appointment] (
    [appointmentID]   VARCHAR (50) NOT NULL,
    [patientsID]      VARCHAR (50) NULL,
    [userID]          VARCHAR (50) NULL,
    [appointmentDate] DATE         NULL,
    [startTime]       TIME (7)     NULL,
    [endTime]         TIME (7)     NULL,
    [status]          NVARCHAR(50)          NULL,
    PRIMARY KEY CLUSTERED ([appointmentID] ASC),
    CONSTRAINT [fk_patientsID] FOREIGN KEY ([patientsID]) REFERENCES [dbo].[Patients] ([patientsID]),
    CONSTRAINT [fk_userID] FOREIGN KEY ([userID]) REFERENCES [dbo].[Users] ([userID])
);
CREATE TABLE [dbo].[Treatment] (
    [treatmentID]     VARCHAR (50) NOT NULL,
    [patientsID]      VARCHAR (50) NOT NULL,
    [userID]          VARCHAR (50) NOT NULL,
    [startDate]       DATE         NULL,
    [endDate]         DATE         NULL,
    [treatmentDetail] NVARCHAR(MAX)         NULL,
    [advice]          NVARCHAR(MAX)         NULL,
    PRIMARY KEY CLUSTERED ([treatmentID] ASC),
    CONSTRAINT [fk_Treatment_patientsID] FOREIGN KEY ([patientsID]) REFERENCES [dbo].[Patients] ([patientsID]),
    CONSTRAINT [fk_Treatment_userID] FOREIGN KEY ([userID]) REFERENCES [dbo].[Users] ([userID])
);
CREATE TABLE [dbo].[Service]
(
	[serviceID] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [serviceName] VARCHAR(50) NULL, 
    [cost] FLOAT NULL,
    [unit] varchar(10)
);
CREATE TABLE [dbo].[Service_Treatment]
(
	[treatmentID] VARCHAR(50) NOT NULL, 
    [serviceID] VARCHAR(50) NOT NULL,
    [amount] int null,
	CONSTRAINT pk_Service_Treatment PRIMARY KEY(treatmentID, serviceID),
	CONSTRAINT fk_Service_Treatment_treatmentID FOREIGN KEY (treatmentID) REFERENCES Treatment (treatmentID),
	CONSTRAINT fk_Service_Treatment_serviceID FOREIGN KEY (serviceID) REFERENCES Service (serviceID)
)
CREATE TABLE [dbo].[Medicine]
(
	[medicineID] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [medicineName] NVARCHAR(255) NULL, 
    [cost] FLOAT NULL,
    [unit] varchar(10)
)

CREATE TABLE [dbo].[Medicine_Treatment]
(
	[treatmentID] VARCHAR(50) NOT NULL, 
    [medicineID] VARCHAR(50) NOT NULL, 
    [amount] INT NOT NULL,
	CONSTRAINT pk_Medicine_Treatment PRIMARY KEY(treatmentID, medicineID),
	CONSTRAINT fk_Medicine_Treatment_treatmentID FOREIGN KEY (treatmentID) REFERENCES Treatment (treatmentID),
	CONSTRAINT fk_Medicine_Treatment_serviceID FOREIGN KEY (medicineID) REFERENCES Medicine (medicineID)

)
CREATE TABLE [dbo].[Bill]
(
	[billID] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [patientsID] VARCHAR(50) NOT NULL, 
    [treatmentID] VARCHAR(50) NOT NULL, 
    [totalCost] FLOAT NULL, 
    [exportBillDate] DATETIME NULL,
	CONSTRAINT fk_Bill_treatmentID FOREIGN KEY (treatmentID) REFERENCES Treatment (treatmentID),
	CONSTRAINT fk_Bill_patientsID FOREIGN KEY (patientsID) REFERENCES Patients (patientsID)
)




