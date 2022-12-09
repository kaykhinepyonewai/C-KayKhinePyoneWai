select m.FullNames,m.Address,r.MovieRented,s.Salutation from Member as m,Rent as r,Salutation as s where m.MemberId=r.MemberId and m.SalutationId=s.SalutationId
