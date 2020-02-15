#!/bin/bash
TestingRegularExpression(){
	nameRE="^[A-Za-z]*$"
	emailRE="^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$"
	passwordRE="^[A-Za-z0-9\@\_\]*$"
	mobileRE="^[0-9]{10}$"

	echo ""
	if [[ $firstname =~ $nameRE ]];
	then
		echo "Firstname is Valid"
	else
		echo "Firstname is Invalid"
	fi
	
	if [[ $lastname =~ $nameRE ]];
	then
		echo "Lastname is Valid";
	else
		echo "Lastname is Invalid";
	fi

	if [[ $email =~ $emailRE ]];
	then
		echo "Email is Valid";
	else
		echo "Email is Invalid";
	fi

	if [[ $password =~ $passwordRE ]];
	then
		echo "Password is Valid";
	else
		echo "Password is Invalid";
	fi

	if [[ $mobile =~ $mobileRE ]];
	then
		echo "Mobile number is Valid";
	else
		echo "Mobile number is Invalid";
	fi
}

echo -n "First Name: "
read firstname
echo -n "Last Name: "
read lastname
echo -n "Email: "
read email
echo -n "Password: "
read password
echo -n "Mobile: "
read mobile

TestingRegularExpression