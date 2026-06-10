#!/bin/bash

read -p"Enter the fileName to see last Modification : " path

if [ -e $path ]
then 
   echo "$(date -r "$path")"
else
   echo "The entered filename doesn't exist"
fi
