#!/bin/bash

count=0

for entry in `ls`
do
   if [[ -f $entry ]]
   then	   
   ((count++))
   fi
done

echo "File Count = $count"
