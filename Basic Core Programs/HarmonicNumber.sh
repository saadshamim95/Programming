#!/bin/bash
printf "Enter the value of N: "
read N
while((N <= 0))
do
	printf "Enter the value of N: "
	read N
done
result=0
for((i=1;i<=N;i++))
do
	result=$(echo | awk -v temp=$result -v i=$i '{print(temp+1/i)}')
	printf "1/$i + "
done
echo ""
echo $N"th Harmonic Number: $result"