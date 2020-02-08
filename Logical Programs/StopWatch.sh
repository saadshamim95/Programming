#!/bin/bash
printf "Press any key to start!!!"
read start
echo "Starting Stopwatch..."
let start_time=$(date +%s)
while(true)
do
	let current_time=$(date +%s)
	let seconds=$((current_time-start_time))
	echo -en "\r            \r"
	printf "Timer: %02d:%02d:%02d" "$((seconds/3600%24))" "$((seconds/60%60))" "$((seconds%60))"
	sleep 0.1
done