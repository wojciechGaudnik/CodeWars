import functools


def num_primorial(n):
	primes = []
	i = 1
	while len(primes) < n:
		if isPrime(i):
			primes.append(i)
		i += 1
	return functools.reduce(lambda a,b : a * b, primes)


def isPrime(n):
	if n == 2 or n == 3: return True
	if n % 2 == 0 or n < 2: return False
	for i in range(3, int(n ** 0.5) + 1, 2):
		if n % i == 0:
			return False
	return True

