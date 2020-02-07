#!/bin/bash
printf "Enter Stake: "
read stake
printf "Enter Goal: "
read goal
number=0
wins=0
RANDOM=$$
while((stake!=0 && goal!=stake))
do
	if(($RANDOM%2==0))
	then
		wins=$((wins+1))
		stake=$((stake+1))
	else
		stake=$((stake-1))
	fi
	number=$((number+1))
done

if((stake==0))
then
	echo -e "Gambler is broke!!!\n"
fi
if((stake==goal))
then
	echo -e "Goal Achieved!!!\n"
fi
winPercent=$(echo | awk -v wins=$wins -v total=$number '{print(wins*100/total)}')
echo "Total Wins: $wins"
echo "Win Percent: $winPercent"
echo "Total Experiment: $number"