#!/bin/bash
printf "Enter the value of N: "
read N
declare -a array
for((i=0;i<N;i++))
do
	array[$i]="false"
done
RANDOM=$$
count=0
number=0
while((count!=N))
do
	position=$(($RANDOM%N))
	if [[ ${array[$position]} == "false" ]] 
	then
		array[$position]="true"
		count=$((count+1))
	fi
	number=$((number+1))
done
echo "Number of Times: $number"