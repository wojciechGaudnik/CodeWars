def next_pal(val):
    while 1:
        val += 1
        if str(val) == str(val)[::-1]:
            return val
