#!/bin/bash

read -p"Enter the number : " num

for i in `seq 1 2 50`
do 
   echo "$num *  $i = $((num * i))"
done
