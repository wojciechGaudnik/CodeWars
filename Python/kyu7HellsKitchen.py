import re


def gordon(a):
    return ' '.join([re.sub(r"[EIOU]", "*", one.upper()).replace("A", "@") + "!!!!" for one in a.split(" ")])


