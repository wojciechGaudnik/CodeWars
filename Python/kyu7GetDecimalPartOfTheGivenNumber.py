import re


def get_decimal(n):
    if type(n) is int:
        return 0
    return float("0" + re.search(r'\.\d+', str(n)).group())
