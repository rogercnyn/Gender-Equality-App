CREATE TABLE [dbo].[usersData]
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
ALTER TABLE [dbo].[usersData] ADD CONSTRAINT [PK__usersDat__CB9A1CDF937DE5B2] PRIMARY KEY CLUSTERED ([userID]) ON [PRIMARY]
GO
