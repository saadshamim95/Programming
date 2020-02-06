#!/bin/sh
printf "Enter the number of times you want to flip Coin: "
read num
while((${#num}<=0))
do
	printf "Enter the number of times you want to flip Coin: "
	read num
done
head=0
tails=0
RANDOM=$$
for((i=0;i<$num;i++))
do
	if(($RANDOM%2==0))
	then
		head=$((head+1))
	else
		tails=$((tails+1))
	fi
done
echo "Number of Heads: $head"
echo "Number of Tails: $tails"