#!/bin/bash

echo "Enter the Year : "
read year

if [ $((year % 4)) -eq 0 ]
then 
   echo "Year is Leap"
else
   echo "Year is not leap"
fi
