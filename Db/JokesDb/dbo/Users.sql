﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NickName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(300) NOT NULL UNIQUE, 
    [Password] NVARCHAR(256) NOT NULL, 
    [BirthDate] DATE NOT NULL
)