#!/bin/bash

read -p"Enter the number to find Factorial : " num

i=1
fact=1
while [ $i -le $num ]
do
   fact=`expr $fact \* $i`
   ((i++))
done 

echo "Factorial of $num is : $fact"

