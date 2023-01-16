def largest_power(N):
    if N <= 1:
        return -1
    last_k = 0
    current_k = 0
    while 3 ** current_k < N:
        last_k = current_k
        current_k += 1
    return last_k
