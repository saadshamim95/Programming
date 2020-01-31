Create Procedure emGetAllEmployee
as
Begin
	Select *
	from Employee
	Order By Name
End