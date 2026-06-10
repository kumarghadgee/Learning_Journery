#!/bin/bash

read -p"Enter the file1 and file2  : " file1 file2


if [ -f $file1 ]
then	
  cat "$file1" >> "$file2"
  echo "Successfully appended the file1 to file2"
else
  echo  "Error: "$file1" doesn't exist"
fi
