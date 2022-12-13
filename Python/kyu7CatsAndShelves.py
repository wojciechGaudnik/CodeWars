def solution(start, finish):
    answer = 0
    while finish - start >= 3:
       answer += 1
       start += 3
    if start == finish:
        return answer
    elif finish - start == 2:
        return answer + 2
    elif finish - start == 1:
        return answer + 1

