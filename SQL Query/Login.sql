Create Procedure emLoginEmployee
(
	@Email varchar(30),
	@Pass varchar(20)
)
as
Begin
	Select Email, Pass
	From Employee
	Where Email=@Email AND Pass=@Pass
End