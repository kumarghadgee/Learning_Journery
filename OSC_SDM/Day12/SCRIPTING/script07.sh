#!/bin/bash

read -p"Enter two Operands : " op1 op2

echo -e "1.ADD\2.SUB\3.MUL\4.DIV"
echo -n "Enter your Choice : "
read choice

case $choice in
1) echo "$op1 + $op2 = $((op1 + op2))"
   ;;
2) echo "$op1 - $op2 = $((op1 - op2))"
   ;;
3) echo "$op1 * $op2 = $((op1 * op2))"
   ;;
4) echo "$op1 / $op2 = $((op1 / op2))"
   ;;
*) echo "Invalid Operation.."
   ;;
esac
