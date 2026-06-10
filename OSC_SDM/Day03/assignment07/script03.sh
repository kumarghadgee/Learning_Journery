#!/bin/bash

echo -n "Enter the File or Directory Name : " ; read file

filesame=$(stat -c%s "$file")
if [ -f $file ]
then    	
   echo "Is a File.Size : $filesame"
elif [ -d $file ]
then 
   echo "Is a DIrectory " ; ls
else
   echo "Not a FIle / Directory "
fi
