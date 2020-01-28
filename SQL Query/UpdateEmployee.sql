Create Procedure emUpdateEmployee
(
	@EmployeeId int,
	@FirstName varchar(20),
	@LastName varchar(20),
	@UserName varchar(20),
	@Pass varchar(20),
	@Email varchar(30),
	@Mobile varchar(10)
)
as
Begin
	Update Employee
	set FirstName=@FirstName,
	LastName=@LastName,
	UserName=@UserName,
	Pass=@Pass,
	Email=@Email,
	Mobile=@Mobile
	Where EmployeeId=@EmployeeId
End