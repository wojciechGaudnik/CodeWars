def is_narcissistic(i):
    return sum([pow(int(n), len(str(i))) for n in str(i)]) == i
