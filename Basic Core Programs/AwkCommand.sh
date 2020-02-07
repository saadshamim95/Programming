#!/bin/bash
echo "Starting"
read x
s=$(echo | awk -v y=$x '{print(y*0.76)}')
echo "s: $s"
echo "Ending"