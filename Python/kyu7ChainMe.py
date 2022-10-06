def chain(init_val, functions):
    answer = init_val
    for function in functions:
        answer = function(answer)
    return answer
