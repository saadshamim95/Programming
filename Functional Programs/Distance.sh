#!/bin/bash
x=$1
y=$2
res=$((x*x+y*y))
Distance=$(echo | awk -v res=$res '{print(res**0.5)}')
echo "Distance = $Distance"