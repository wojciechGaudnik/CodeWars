def presses(phrase):
    answer = 0
    odd = {'1': 1, 'S': 4, '7': 5, 'Z': 5, '9': 5, ' ': 1, '0': 2, '#': 1, '*': 1, 'V': 4, 'Y': 4}
    for c in phrase.upper():
        if odd.__contains__(c):
            answer += odd[c]
        elif c.isdigit():
            answer += 4
        else:
            answer += (ord(c) - 65) % 3 + 1
        if c >= 'T':
            answer -= 1
    return answer


