CREATE TABLE [dbo].[JokesCategories]
(
	[IdJoke] INT NOT NULL ,
	[IdCategory] INT NOT NULL, 
    CONSTRAINT [FK_JokesCategories_ToJokes] FOREIGN KEY ([IdJoke]) REFERENCES [Jokes]([Id]), 
    CONSTRAINT [FK_JokesCategories_ToCategories] FOREIGN KEY ([IdCategory]) REFERENCES [Categories]([Id]) 
)
