def divisible_by_three(st):
    sum_all = sum(list(map(lambda s: int(s), list(st))))
    number = 3
    while number <= sum_all:
        if number == sum_all:
            return True
        number += 3
    return False
