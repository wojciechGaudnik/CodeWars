import re


def closest_multiple_10(i):
    last = re.search(r'\d\.+\d+$', str(i))
    if last:
        return float((i // 10) * 10 if float(last.group()) < 5 else ((i // 10) + 1) * 10)
    else:
        return (i // 10) * 10 if int(str(i)[-1]) < 5 else ((i // 10) + 1) * 10
