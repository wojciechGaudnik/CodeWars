def find_lowest_int(k):
    answer = 1
    while sorted(str(k * answer)) != sorted(str((k + 1) * answer)):
        answer += 1
    return answer
