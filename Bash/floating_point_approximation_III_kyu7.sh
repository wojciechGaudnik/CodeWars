#!/bin/bash
function quadratic() {
  #  bc <<< "scale=$1; -$3 / $2"
  echo "a = $3"
  echo "b = $3"
  echo "c = $3"
  bc <<<"scale=10; -$3 / $2"
}
quadratic $1 $2 $3
