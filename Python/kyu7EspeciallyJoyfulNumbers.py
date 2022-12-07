def number_joy(n):
    s = sum([int(o) for o in str(n)])
    sr = int(str(s)[::-1])
    return s * sr == n
