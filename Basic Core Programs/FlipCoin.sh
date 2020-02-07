#!/bin/sh
printf "Enter the number of times you want to flip Coin: "
read num
while((${#num}<=0))
do
	printf "Enter the number of times you want to flip Coin: "
	read num
done
head=0
tail=0
RANDOM=$$
for((i=0;i<$num;i++))
do
	if(($RANDOM%2==0))
	then
		head=$((head+1))
	else
		tail=$((tail+1))
	fi
done
echo "Number of Heads: $head"
echo "Number of Tails: $tail"
headPercent=$(echo | awk -v head=$head -v total=$num '{print(head*100/total)}')
tailPercent=$(echo | awk -v tail=$tail -v total=$num '{print(tail*100/total)}')
echo "Head Percentage: $headPercent%"
echo "Tail Percentage: $tailPercent%"