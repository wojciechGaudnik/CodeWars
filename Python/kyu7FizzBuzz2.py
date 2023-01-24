def solution(number):
    answer = [0, 0, 0]
    A, B, C = 0, 1, 2
    for n in range(1, number):
        if n % 3 is 0 and n % 5 is 0:
            answer[C] += 1
        elif n % 3 is 0 and n % 5 != 0:
            answer[A] += 1
        elif n % 5 is 0 and n % 3 != 0:
            answer[B] += 1
    return answer
