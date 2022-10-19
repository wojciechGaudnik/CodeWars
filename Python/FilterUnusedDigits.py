from functools import reduce


def unused_digits(*numbers):
    if numbers:
        return "".join(sorted(set("0123456789") - set(reduce(lambda a, b: a + b, list(map(lambda number: str(number), numbers))))))
    return "0123456789"
