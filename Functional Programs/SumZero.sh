#!/bin/bash
declare -a array
declare -a triplets
array=(5 4 3 -3 -1 -2 6 -9 7 -4)
n=10
count=0
num=0
for((i=0;i<$n-2;i++))
do
	for((j=$i+1;j<$n-1;j++))
	do
		for((k=$j+1;k<n;k++))
		do
			if(( $((array[$i]+array[$j]+array[$k]))==0 ))
			then
				#echo "Found"
				count=$((count+1))
				triplets[${#triplets[@]}]=$((array[$i]))
				triplets[${#triplets[@]}]=$((array[$j]))
				triplets[${#triplets[@]}]=$((array[$k]))
			fi
		done
	done
done
echo "Count: $count"
for((i=0;i<count;i++))
do
	for((j=0;j<3;j++))
	do
		#echo "${triplets[$((3*i+j))]} "
		printf "%d " "${triplets[$((3*i+j))]}"
	done
	echo ""
done