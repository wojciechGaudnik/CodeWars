def candies(s):
    if len(s) <= 1:
        return -1
    biggest = max(s)
    s.remove(biggest)
    answer = 0
    for one in s:
        answer += biggest - one
    return answer
