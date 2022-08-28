def counting_valleys(s):
    answer = 0
    level = 0
    for one in s:
        if level == -1 and one == 'U':
            answer += 1
            level = 0
        elif one == 'U':
            level += 1
        elif one == 'D':
            level -= 1
    return answer
