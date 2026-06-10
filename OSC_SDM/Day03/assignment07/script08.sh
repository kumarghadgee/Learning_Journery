#!/bin/bash

read -p"Enter the number " num

i=1

while [ $i -le 10 ]
do 
   result=`echo "$num * $i" | bc`
   echo "$num * $i =  $result "
   ((i++))
done
