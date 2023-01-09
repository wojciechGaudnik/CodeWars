def match_arrays(v, r):
    answer = 0
    for one in v:
        if one in r:
            answer += 1
    return answer
