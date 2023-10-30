CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [IsAdult] BIT NOT NULL DEFAULT 0 
)
