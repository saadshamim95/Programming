Create Procedure emGetAllEmployee
as
Begin
	Select *
	from Employee
	Order By EmployeeId
End