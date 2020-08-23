import operator
from collections import Counter
from functools import reduce


def oddity(n):
	p = 2
	factors = []
	while n >= p ** 2:
		if n % p == 0:
			factors.append(p)
			n //= p
			continue
		p += 1
	factors.append(n)
	factors = Counter(factors).values()
	if n == 1:
		return 'odd'
	return "even" if reduce(operator.mul, [e + 1 for e in factors]) % 2 == 0 else "odd"
