import random


def generate(length):
    answer = ''
    while len(answer) < length:
        answer += str(random.randint(0, 1))
    return answer
