#!/bin/sh
printf "Enter the value of N: "
read N
while((N<0 || N>30))
do
	printf "Enter the value of N: "
	read N
done
for((i=0;i<N;i++))
do
	echo "2 to the power $i = $((2**$i))"
done
echo "*****Complete*****"