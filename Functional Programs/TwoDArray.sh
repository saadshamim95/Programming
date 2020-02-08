#!/bin/bash
declare -A array
printf "Enter number of rows: "
read rows
printf "Enter number of columns: "
read col
for((i=0;i<$rows;i++))
do
	for((j=0;j<$col;j++))
	do
		read array[$i,$j]
	done
done

for((i=0;i<$rows;i++))
do
	for((j=0;j<$col;j++))
	do
		printf "${array[$i,$j]} "
	done
	echo ""
done