CREATE TABLE [dbo].[Jokes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL, 
    [IdUser] INT NOT NULL, 
    [CreationDate] DATETIME NOT NULL, 
    [Rating] TINYINT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Jokes_To_Users] FOREIGN KEY (IdUser) REFERENCES [Users]([Id])
)
