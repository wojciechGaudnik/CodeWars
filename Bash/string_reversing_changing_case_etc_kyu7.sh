#!/usr/bin/env bash
first=$(echo $1 |rev)
first+=$1
second=$(echo $2 |rev)
upperSecond=${second^^}
lowerSecond=${second,,}
upperFirst=${first^^}
lowerFirst=${first,,}
answer=""
for (( i = 0; i < ${#second}; i++ )); do
  if [[ ${second:i:1} == [A-Z] ]]; then
    answer=$answer"${lowerSecond:i:1}"
  else
    answer=$answer"${upperSecond:i:1}"
  fi
done
answer+="@@@"
for (( i = 0; i < ${#first}; i++ )); do
  if [[ ${first:i:1} == [A-Z] ]]; then
    answer=$answer"${lowerFirst:i:1}"
  else
    answer=$answer"${upperFirst:i:1}"
  fi
done
echo $answer