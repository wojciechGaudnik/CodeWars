def are_coprime(n,m):
    smaller = min(n,m)
    for number in range(2, smaller + 1):
        if n % number == 0 and m % number == 0:
            return False
    return True
