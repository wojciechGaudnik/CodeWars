def vampire_test(x, y):
    if x < 0 and y < 0:
        return False
    return sorted(str(x) + str(y)) == sorted(str(x * y))

# BIG_BUG
