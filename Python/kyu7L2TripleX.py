import re


def triple_x(s):
    results = re.findall(r'x{1,3}', s)
    if len(results) != 0 and results[0] == "xxx":
        return True
    return False
