#!/bin/bash
echo "Press any key to start the timer"
read
h1=$(date +%H)
m1=$(date +%M)
s1=$(date +%S)
echo "start time is $h1:$m1:$s1"

echo "Press any key to stop the timer"
read
h2=$(date +%H)
m2=$(date +%M)
s2=$(date +%S)
echo "stop time is $h2:$m2:$s2"

H=$(($h2-$h1))
M=$(($m2-$m1))
S=$(($s2-$s1))
if((S<0))
then
	S=$((60+S))
	M=$((M-1))
fi
printf  "Difference of time = %02d:%02d:%02d" "$H" "$M" "$S"