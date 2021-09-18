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

old="00123"
new=${old##+(0)}
printf $new