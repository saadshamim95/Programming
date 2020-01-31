Create Procedure emAddEmployee
(
	@Name varchar(50),
	@UserName varchar(20),
	@Pass varchar(20),
	@Email varchar(30),
	@Mobile varchar(10)
)
as
Begin
	Insert Into Employee (Name, UserName, Pass, Email, Mobile)
	Values (@Name, @UserName, @Pass, @Email, @Mobile)
End