Create Procedure emDeleteEmployee
(
	@EmployeeId int
)
as
Begin
	Delete From Employee Where EmployeeId=@EmployeeId
End