#!/bin/bash

count=0

for entry in `ls`
do
   if [[ -d $entry ]]
   then	   
   ((count++))
   fi
done

echo "File Count = $count"
