#!/bin/bash
printf "Enter the value of a: "
read a
printf "Enter the value of b: "
read b
printf "Enter the value of c: "
read c
delta=$((b*b-4*a*c))
#echo $delta
root1=$(echo | awk -v delta=$delta -v a=$a -v b=$b '{print((-b+delta**0.5)/2*a)}')
root2=$(echo | awk -v delta=$delta -v a=$a -v b=$b '{print((-b-delta**0.5)/2*a)}')
echo "Root 1: $root1"
echo "Root 2: $root2"