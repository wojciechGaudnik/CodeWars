import operator
from collections import Counter
from functools import reduce


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


def oddity(n):
	if n == 1:
		return 'odd'
	return "even" if reduce(operator.mul, [e + 1 for e in PrimeFactorizer(n).factor.values()]) % 2 == 0 else "odd"


def divCount1(n):
	hh = [1] * (n + 1)
	p = 2
	while (p * p) < n:
		if hh[p] == 1:
			for i in range((p * 2), n, p):
				hh[i] = 0
		p += 1
	total = 1
	for p in range(2, n + 1):
		if hh[p] == 1:
			count = 0
			if n % p == 0:
				while n % p == 0:
					n = int(n / p)
					count += 1
				total *= (count + 1)
	return total





