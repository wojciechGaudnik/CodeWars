def ball_test(s, r):
    start_index = 0
    stop_index = s
    while stop_index < len(r) and s > 0:
        rocks = r[start_index:stop_index].count('x')
        s -= (1 + rocks)
        start_index = stop_index + 1
        stop_index += s
    return s > 0 or stop_index >= len(r)
