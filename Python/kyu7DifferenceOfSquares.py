import math


def difference_of_squares(n):
    return int(math.pow(sum([i for i in range(1, n + 1)]), 2) - sum([math.pow(i, 2) for i in range(1, n + 1)]))

