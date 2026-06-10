#!/bin/bash


echo "Enter the Number : "
read num

if [ $num -eq 0 ]
then 
   echo "Number is zero"
elif [ $num -lt 0 ]
then 
   echo "Number is negative"
else
   echo "Number is positive"
fi
