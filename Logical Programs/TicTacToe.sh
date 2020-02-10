#!/bin/bash
declare -A array

user=0
win=0
accept=0
count=0
row=-1
col=-1

initialize() {
	for((i=0;i<3;i++))
	do
		for((j=0;j<3;j++))
		do
			array[$i,$j]=9
		done
	done
}

isFree() {
	if(( ${array[$1,$2]} == 9 ))
	then
		accept=1
		return
	else
		accept=0
		return
	fi
}

Print() {
	for((i=0;i<3;i++))
	do
		for((j=0;j<3;j++))
		do
			printf "${array[$i,$j]} "
		done
		echo ""
	done
}

checkForWin() {
	#Row 1
	if(( ${array[0,0]}==$1 && ${array[0,1]}==$1 && ${array[0,2]}==$1 ))
	then
		echo "Row 1"
		win=1
		return
	fi
	
	#Row 2
	if(( ${array[1,0]}==$1 && ${array[1,1]}==$1 && ${array[1,2]}==$1 ))
	then
		echo "Row 2"
		win=1
		return
	fi
	
	#Row 3
	if(( ${array[2,0]}==$1 && ${array[2,1]}==$1 && ${array[2,2]}==$1 ))
	then
		echo "Row 3"
		win=1
		return
	fi
	
	#Col 1
	if(( ${array[0,0]}==$1 && ${array[1,0]}==$1 && ${array[2,0]}==$1 ))
	then
		echo "Col 1"
		win=1
		return
	fi
	
	#Col 2
	if(( ${array[0,1]}==$1 && ${array[1,1]}==$1 && ${array[2,1]}==$1 ))
	then
		echo "Col 2"
		win=1
		return
	fi
	
	#Col 3
	if(( ${array[0,2]}==$1 && ${array[1,2]}==$1 && ${array[2,2]}==$1 ))
	then
		echo "Col 3"
		win=1
		return
	fi
	
	#Diagonol 1
	if(( ${array[0,0]}==$1 && ${array[1,1]}==$1 && ${array[2,2]}==$1 ))
	then
		echo "Diagonol 1"
		win=1
		return
	fi
	
	#Diagonol 2
	if(( ${array[2,0]}==$1 && ${array[1,1]}==$1 && ${array[0,2]}==$1 ))
	then
		echo "Diagonol 2"
		win=1
		return
	else
		win=0
		return
	fi
}

initialize
#Print

while(( win!=1 && count!=9 ))
do
	RANDOM=$$
	if((user==0))
	then
		echo "Computer's Turn:"
		accept=0
		while((accept!=1))
		do
			row=$(($RANDOM%3))
			col=$(($RANDOM%3))
			isFree $row $col
		done
		array[$row,$col]=1
		user=1
		Print
		count=$((count+1))
		if((count>4))
		then
			checkForWin 1
			if((win==1))
			then
				echo "Computer has won!"
			fi
		fi
	else
		accept=0
		while((accept!=1))
		do
			echo "User's Turn:"
			read row
			read col
			isFree $row $col
		done
		array[$row,$col]=0
		user=0
		Print
		count=$((count+1))
		if((count>4))
		then
			checkForWin 0
			if((win==1))
			then
				echo "User has won!"
			fi
		fi
	fi
done
if((win==0))
then
	echo "Match drawn!!!"
fi