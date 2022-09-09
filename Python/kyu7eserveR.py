def reverse(lst):
    answer = list()
    while lst:
        answer.append(lst[-1])
        lst.pop()
    return answer
