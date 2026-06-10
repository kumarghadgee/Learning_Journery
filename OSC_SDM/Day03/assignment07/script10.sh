#!/bin/bash

read -p"Enter the number : " num

a=0
b=1
i=0

while [ $i -lt $num ]
do
  echo "$a"

  fn=$((a + b ))
  a=$b
  b=$fn

  ((i++))
  
done
