def seqlist(first, c, l):
    answer = [first]
    while len(answer) < l:
        answer.append(answer[-1] + c)
    return answer
