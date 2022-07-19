from collections import Counter


def hist(string):
    counter = Counter(string)
    answer = ''
    errors = ['u', 'w', 'x', 'z']
    for error in errors:
        space = 5
        if counter[error] >= 10:
            space = 4
        if counter[error] > 0:
            answer += error + '  ' + str(counter[error]) + (' ' * space) + ('*' * counter[error]) + '\r'
    return answer.rstrip('\r')
