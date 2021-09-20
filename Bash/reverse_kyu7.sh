#!/usr/bin/sh
#copy=$1
#len=${#copy}
#for ((i=$len-1;i>=0;i--));
#do
#    rev="$rev${copy:$i:1}"
#done
#set rev
#foreach s ( $1 )
#  rev=$s + $rev
#end
#echo $rev

#old=00123
#echo $old
#printf %10d $1|rev
echo "---"
a=$(echo $1|rev)
b=$(echo $a | sed 's/^0*//')
echo $b

#echo $(echo $1|rev)
echo $1|rev| sed 's/^0*//'

echo "---"
c=$(echo $1|rev)

echo "3333333333-------"
x=$(echo $1|rev)
echo $x | awk '{$0=int($0)}1'
http://underpop.online.fr/u/unix-school/guru-prasad/how-to-remove-leading-zeros-in-string.htm