import math


def heron(a, b, c):
    s = (a + b + c) / 2
    return round(math.sqrt(s * (s - a) * (s - b) * (s - c)), 2)
