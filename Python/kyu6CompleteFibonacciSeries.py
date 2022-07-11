def fibonacci(n):
    if n < 1:
        return []
    if n == 1:
        return [0]
    answer = []
    f0 = 0
    f1 = 1
    f2 = 1
    for i in range(1, n +1):
        answer.append(f0)
        f0 = f1
        f1 = f2
        f2 = f0 + f1
    return answer
