#!bin/sh
printf "Enter Username: "
read username
while((${#username} < 3 ))
do
	printf "Enter Username: "
	read username
done
echo "Hello $username, How are you?"
