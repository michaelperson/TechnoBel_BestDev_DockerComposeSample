CREATE VIEW [dbo].[VuSersBlagues]
	AS SELECT NickName, Jokes.Title, Jokes.Content FROM Jokes
	inner join Users
	on Users.id=Jokes.IdUser
