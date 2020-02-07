#!/bin/bash
t=$1
v=$2
w=0
if((t>50 || v>120 || v<3))
then
	echo "Formula Invalid"
else
	w=$(echo | awk -v t=$t -v v=$v '{print(35.74 + 0.6215*t + (0.4275*t - 35.75)*v^0.16 )}')
fi
echo "Effective Temperature: $w"