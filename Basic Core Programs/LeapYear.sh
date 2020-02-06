#!/bin/sh
printf "Enter the year: "
read year
while(($year<1000 || $year>9999))
do
	printf "Enter the year: "
	read year
done
if(($year%400==0 || ($year%4==0 && $year%100!=0)))
then
	echo "$year is Leap year"
else
	echo "$year is not a Leap Year"
fi