import math


def vector_length(vector):
    x1 = vector[0][0]
    x2 = vector[1][0]
    y1 = vector[0][1]
    y2 = vector[1][1]
    return math.hypot((x2 - x1), (y2 - y1))

