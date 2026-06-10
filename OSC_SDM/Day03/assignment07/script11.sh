#!/bin/bash

read -p"Enter the Salary : " sal

gross=$(echo "sal * 0.40 + $sal * 0.20 + $sal" | bc)

echo "Gross Salary = $gross"
