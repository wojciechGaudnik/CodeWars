#!/usr/bin/env bash

mon=$1
mon=${mon,,}
mon=${mon:0:3}
mon_num=0
case $mon in
  jan) mon_num=1;;
  feb) mon_num=2;;
  mar) mon_num=3;;
  apr) mon_num=4;;
  may) mon_num=5;;
  jun) mon_num=6;;
  jul) mon_num=7;;
  aug) mon_num=8;;
  sep) mon_num=9;;
  oct) mon_num=10;;
  nov) mon_num=11;;
  dec) mon_num=12;;
esac
printf "%02d" $mon_num