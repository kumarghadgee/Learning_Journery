#!/bin/bash

echo "Please Enter the Number : "
read num

if [ $num -le 1 ]
then 
   echo "It is not a prime Number.."
   exit
fi

div=2
isPrime=1

while [ $((div * div)) -le $num ]
do 
    if [ $((num % div)) -eq 0 ]
      then
	 isPrime=0
	 break
   fi
   ((div++))
done

if [ $isPrime -eq 1 ]
then 
   echo "Number is Prime "
else
   echo "Number is not Prime "
fi
