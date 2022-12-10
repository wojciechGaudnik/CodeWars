import math


def is_square(arr):
    if not arr:
        return None
    for one in arr:
        sqrt = math.sqrt(one)
        if sqrt != int(sqrt):
            return False
    return True
