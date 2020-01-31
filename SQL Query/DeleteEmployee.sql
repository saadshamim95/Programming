Create Procedure emDeleteEmployee
(
	@Email varchar(30)
)
as
Begin
	Delete From Employee Where Email=@Email
End