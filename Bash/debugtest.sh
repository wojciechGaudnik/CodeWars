#! /bin/bash
echo "alaa"
set -x
echo "ala1"
echo "ala2"
set +x
echo "ala3"
echo $1
# read test
echo "$test <---test"
arr1=('c' 'd')
echo "${arr1[1]}"
unset arr1[1]
echo "${arr1[1]}"
arr1[1]='ala'
echo "${arr1[1]}"

count=10
#read test
test=10
if [ $count -eq $test ]
then
	echo "true"
else
	echo "false"
fi

value="gues"
#read test
test="gues"
if [ $value = $test ]
then
 	echo "equals"
else
	echo "not equals"
fi

read filename
if [ -f "$filename" ] && [-w "$filename" ]
then
	echo "hello" > $filename
else
	touch "$filename"
	echo "hello" > $filename
fi
