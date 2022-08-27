def binary_pyramid(m, n):
    answer = bin(m)[2:]
    for number in range(m + 1, n + 1):
        answer = str(eval(answer + " + " + bin(number)[2:]))
    return bin(int(answer, 10))[2:]
