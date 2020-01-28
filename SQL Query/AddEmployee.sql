Create Procedure emAddEmployee
(
	@FirstName varchar(20),
	@LastName varchar(20),
	@UserName varchar(20),
	@Pass varchar(20),
	@Email varchar(30),
	@Mobile varchar(10)
)
as
Begin
	Insert Into Employee (FirstName, LastName, UserName, Pass, Email, Mobile)
	Values (@FirstName, @LastName, @UserName, @Pass, @Email, @Mobile)
End