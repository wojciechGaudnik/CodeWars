def sum_no_duplicates(l):
    answer = 0
    for one in l:
        if l.count(one) == 1:
            answer += one
    return answer
