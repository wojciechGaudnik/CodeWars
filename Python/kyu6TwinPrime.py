# noinspection SpellCheckingInspection
def is_twinprime(n):
    arr = [is_prime(n - 2), is_prime(n), is_prime(n + 2)]
    return (arr[0] == arr[1] and arr[0]) or (arr[1] == arr[2] and arr[1])


# noinspection DuplicatedCode
def is_prime(n):
    if n == 2 or n == 3: return True
    if n % 2 == 0 or n < 2: return False
    for i in range(3, int(n ** 0.5) + 1, 2):
        if n % i == 0:
            return False
    return True
