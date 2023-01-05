import re


def sum_from_string(strng):
    return sum([int(n) for n in re.findall(r'\d+', strng)])
