#!/bin/bash


echo "Enter 1st number : "
read num1

echo "Enter 2nd number : "
read num2

echo "Enter 3rd number : "
read num3


if [ $num1 -gt  $num2 -a  $num1 -gt $num3 ]
then 
   echo "num1 is greatest : $num1 "
elif [ $num2 -gt $num3 ]
then 
   echo "num2 is greatest : $num2 "
else
   echo "num3 is greatest : $num3 "
fi
