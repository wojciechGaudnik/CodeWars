def div_con(x):
    return sum([-int(n) if isinstance(n, str) else n for n in x])