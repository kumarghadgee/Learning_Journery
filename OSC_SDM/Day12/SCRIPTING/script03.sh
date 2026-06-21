#!/bin/bash

read -p"Enter the number : " num

for (( i = 1 ; i <= 10 ; i++ ))
do 
   echo "$num * $i : $((num * i ))"
done

read -p"Enter the number : " num1

for i  in `seq 10`
do
   echo "$num1 * $i : $(expr $num1 \* $i)"
done
