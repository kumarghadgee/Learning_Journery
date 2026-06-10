#!/bin/bash


while [ 1 ]
do
	
echo "1.Date."
echo "2.Calendar."
echo "3.List."
echo "4.Present Working Directory."
echo "5.Exit."
echo  "Please Enter Your Choice : " ; read choice

if [ $choice -eq 1 ]
  then 
     echo -n "Today's Date : " ; date
elif [ $choice -eq 2 ]
  then	
     echo -n "This Months Calendar : " ; cal
elif [ $choice -eq 3 ]
  then
     echo -n "List of the directory : " ; ls
elif [ $choice -eq 4 ]
  then
     echo -n "Present Working Directory : " ; pwd
elif [ $choice -eq 5 ]
   then 
     echo  "Exiting..   " ; exit
else
    echo -n "You Entered the Wrong Choice..."
fi

done 
