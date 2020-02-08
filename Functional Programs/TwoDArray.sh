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

for((k=0;k<$rows;k++))
do
	for((l=0;l<$col;l++))
	do
		printf "${array[$k,$l]} "
	done
	echo ""
done