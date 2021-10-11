#!/bin/bash
i=0
echo "1"
while [ $i -eq 0 ] 
do
        if pgrep -x "sensors-detect" >/dev/null
        then
                echo "is running"
                i=1 
        else
                echo "not running"
        fi  
done

