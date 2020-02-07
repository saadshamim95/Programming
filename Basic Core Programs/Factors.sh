#!/bin/bash
printf "Enter the value whose prime factorization you want to calculate: "
read N
printf "Prime factors of $N: "
for((i=2;i*i<=N;i++))
do
	while(($N%$i==0))
	do
		printf "$i "
		N=$((N/i))
	done
done
if((N > 1))
then
	printf "$N"
fi