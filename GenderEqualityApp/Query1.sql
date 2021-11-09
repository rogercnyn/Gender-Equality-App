CREATE TABLE [dbo].[RegistrationData]
(
[userID] [int] NOT NULL IDENTITY(1, 1),
[userName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[userPassword] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[firstName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[middleName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[lastName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[gender] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[emailAddress] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Birthday] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RegistrationData] ADD CONSTRAINT [PK__Registra__CB9A1CDFBAB46206] PRIMARY KEY CLUSTERED ([userID]) ON [PRIMARY]
GO
;

ALTER TABLE RegistrationData
ALTER COLUMN Birthday VARCHAR(50);

SELECT * FROM RegistrationData;