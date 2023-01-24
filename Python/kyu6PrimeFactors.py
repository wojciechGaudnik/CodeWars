def prime_factors(number):
    all_primes = []
    n = 2
    while n <= number:
        for n in gen_primes():
            if number % n is  0:
                number //= n
                all_primes.append(n)
                break
    return all_primes


def gen_primes():
    D = {}
    q = 2
    while True:
        if q not in D:
            yield q
            D[q * q] = [q]
        else:
            for p in D[q]:
                D.setdefault(p + q, []).append(p)
            del D[q]
        q += 1
