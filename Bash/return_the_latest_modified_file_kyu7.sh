#!/bin/bash
FILES=(*)
latest=${FILES[0]}
for f in ./*;
do
  if [ $latest -ot $f ]; then
    latest=$f
  fi
done

echo $latest
