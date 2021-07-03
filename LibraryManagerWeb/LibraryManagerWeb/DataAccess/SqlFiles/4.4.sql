IF not EXISTS (SELECT * FROM sys. objects WHERE object_id = OBJECT_ID('dbo.MostHighlyRatedBooks') AND type = 'V')
begin
	execute('CREATE VIEW [dbo].[MostHighlyRatedBooks]
	as
		SELECT        TOP (30) b.BookId, b.Title, a.Name, a.LastName, AVG(Convert(decimal(2,1), ISNULL(r.Stars, 0))) as Stars
		FROM            dbo.Books b left JOIN
		dbo.BookRatings r ON b.BookId = r.BookId
		inner join dbo.Authors a on b.AuthorId = a.AuthorId
		group by b.BookId, b.Title, a.Name, a.LastName
		order by Stars desc')
end
go

IF not EXISTS (SELECT * FROM sys. objects WHERE object_id = OBJECT_ID('dbo.MostProlificAuthors') AND type = 'IF')
begin
	execute('create function dbo.MostProlificAuthors(@rows int)
		RETURNS TABLE
	as
	RETURN (
		select TOP ( @rows) a.Name, a.LastName, count(b.BookId) as BookCount from Authors a left join Books b on a.AuthorId = b.AuthorId group by a.Name, a.LastName, b.AuthorId
		order by BookCount  desc)')
end
go
