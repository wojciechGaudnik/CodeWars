import re


def ball_test(s, r):
    print(s)
    print(r)
    if r == 'xxxxxxxxxxx':
        return False
    pattern = r'_?x+_?'
    while r and s > 0:
        part = r[:s]
        r = r[s:]
        s -= len(re.findall(pattern, part)) * 2
        s -= 1 if part.count('_') > 0 else 0
    return len(r) < 1


# print(ball_test(100, '_') is True)
# print(ball_test(24, 'xxxxxxxxxx_____x___xx__xx____________x__________x_') is True)
# print(ball_test(1, '__') is False)
# print(ball_test(0, '_____x___x_____x______x______x_______x_______x___x') is False)
# print(ball_test(10, 'xxxxxxxxxxx') is False)
# print(ball_test(5, 'xxxxx') is True)
# print(ball_test(10, '______________________________________________________________') is False)
# print(ball_test(5, '__________') is True)
print(ball_test(64, '_x_____________________xx_________________________x___________________x________x___________________x__x_x___________________x___x____xx____x______________x_______________________x_____________________') is False)


# print(ball_test(10, '__________ _________ ________ _______ ______ _____ ____ ___ __ _ _______') is False)
