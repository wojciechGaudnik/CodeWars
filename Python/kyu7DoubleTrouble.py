def trouble(x, t):
    start_index = 0
    stop_index = 1
    while stop_index <= len(x) - 1:
        if x[start_index] + x[stop_index] is t:
            x.pop(stop_index)
        elif x[start_index] + x[stop_index] != t:
            start_index += 1
            stop_index = start_index + 1
    return x
