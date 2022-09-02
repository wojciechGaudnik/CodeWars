import math


def geometric_sequence_elements(a, r, n):
    answer = []
    for i in range(n):
        answer.append(str(int(a * math.pow(r, i))))
    return ', '.join(answer)
