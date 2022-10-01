def squares(x, n):
    if n <= 0:
        return []
    answer = [x]
    for _ in range(n - 1):
        answer.append(answer[-1] * answer[-1])
    return answer
