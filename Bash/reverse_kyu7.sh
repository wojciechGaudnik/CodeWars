#!/usr/bin/sh
x=$(echo $1|rev)
echo $x | awk '{$0=int($0)}1'
#http://underpop.online.fr/u/unix-school/guru-prasad/how-to-remove-leading-zeros-in-string.htm