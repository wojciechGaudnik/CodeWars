import math


def powerof4(n):
    if isinstance(n, bool) or not isinstance(n, int) or n < 0:
        return False
    return (math.log(n, 2)/math.log(4, 2)).is_integer()
