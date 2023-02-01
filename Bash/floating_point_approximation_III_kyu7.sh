#!/bin/bash
function quadratic() {
  bc <<<"scale=26;-$3 / $2"
}
quadratic $1 $2 $3
