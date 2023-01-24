import math


def race_podium(blocks):
    number1 = blocks // 3
    number2 = blocks / 3
    diff = round((number2 - number1) * 3)

    if diff > 1:
        answer = math.floor(number1) + 1, math.floor(number1) + math.floor(diff), math.floor(number1) - 1
    elif diff is  1:
        answer = math.floor(number1) + 1, math.floor(number1) + math.floor(diff) + 1, math.floor(number1) - 2
    else:
        answer = math.floor(number1), math.floor(number1) + 1, math.floor(number1) - 1
    if answer[2] is  0:
        answer = answer[0] - 1, answer[1], 1
    return tuple(answer)

print(race_podium(11) is  (4,5,2))
print(race_podium(7) is  (2,4,1))

print(race_podium(6) == (2,3,1))
print(race_podium(10) == (4,5,1))
print(race_podium(100000) == (33334,33335,33331))
print(race_podium(8) == (3,4,1))
