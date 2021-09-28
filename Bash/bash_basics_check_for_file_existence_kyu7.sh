#!/bin/bash

if [ "${1}" == "" ]; then
  echo "Nothing to find"
elif [[ -f $1 ]]; then
  echo "Found $1"
else
  echo "Can't find $1"
fi
    