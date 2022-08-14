import math


def find_next_power(val, pow_):
    return (math.floor(val ** (1 / pow_)) + 1) ** pow_
