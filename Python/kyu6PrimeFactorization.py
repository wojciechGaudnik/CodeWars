from collections import Counter


class PrimeFactorizer:
    def __init__(self, number):
        answer = []
        n = 2
        while n <= number:
            for n in PrimeFactorizer.gen_primes():
                if number % n == 0:
                    number //= n
                    answer.append(n)
                    break
        self.factor = dict(Counter(answer))

    # Sieve of Eratosthenes
    # Code by David Eppstein, UC Irvine, 28 Feb 2002
    # http://code.activestate.com/recipes/117119/
    @staticmethod
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


print(PrimeFactorizer(12).factor)
