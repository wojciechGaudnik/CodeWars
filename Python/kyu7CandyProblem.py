def candies(s):
    if len(s) <= 1:
        return -1
    biggest = max(s)
    s.remove(biggest)
    answer = 0
    for one in s:
        answer += biggest - one
    return answer

print(candies([5,8,6,4]),9)
print(candies([1,2,4,6]),11)
print(candies([1,2]),1)
print(candies([4,2]),2)
