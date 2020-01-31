Create Procedure emUpdateEmployee
(
	@Name varchar(50),
	@UserName varchar(20),
	@Pass varchar(20),
	@Email varchar(30),
	@Mobile varchar(10)
)
as
Begin
	Update Employee
	set Name=@Name,
	UserName=@UserName,
	Pass=@Pass,
	Mobile=@Mobile
	Where Email=@Email
End