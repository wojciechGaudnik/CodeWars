def max_int_chain(n):
    if n <= 4:
        return -1
    c = (n // 2) - 1 if n % 2 == 0 else n // 2
    return c * (n - c)
