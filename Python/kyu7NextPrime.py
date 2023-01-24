def next_prime(n):
    while not isPrime(n):
        n += 1
    return n


def isPrime(n):
    if n is 2 or n is 3: return True
    if n % 2 is 0 or n < 2: return False
    for i in range(3, int(n ** 0.5) + 1, 2):
        if n % i is 0:
            return False
    return True
