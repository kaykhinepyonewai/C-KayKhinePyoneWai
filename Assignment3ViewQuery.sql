 Use Tutorial4;
 GO
 CREATE VIEW[MemberView]
 AS
SELECT        dbo.Member.FullName, dbo.Member.Address, dbo.Rent.MovieRented, dbo.Salutation.Salutation
FROM          dbo.Member INNER JOIN dbo.Rent ON dbo.Member.RentedId = dbo.Rent.RentedId INNER JOIN
			  dbo.Salutation ON dbo.Member.SalutationId = dbo.Salutation.SalutationId
GO



