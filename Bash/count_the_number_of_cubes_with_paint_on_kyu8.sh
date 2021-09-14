function run_shell() {
  if [ $1 -eq 0 ]; then
    echo 1
  else
    # shellcheck disable=SC2046
    echo $(expr 6 \* $1 \* $1 + 2)
 fi
}

