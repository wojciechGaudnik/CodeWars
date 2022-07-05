def count(array):
    answer = {}
    for e in array:
        if e in answer:
            answer[e] += 1
        else:
            answer[e] = 1
    return answer
