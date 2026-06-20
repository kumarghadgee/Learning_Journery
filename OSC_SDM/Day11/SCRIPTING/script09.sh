#!/bin/bash

read -p"Enter the number : " num

for i in `seq 11 2 20`
do 
   echo "$num *  $i = $((num * i))"
done
