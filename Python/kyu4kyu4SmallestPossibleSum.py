def solution(a):
	if a[1:] == a[:-1]:
		return a[0] * len((a))
	for n in a:
		if n == 1:
			return len(a)
	length = len(a)
	a = list(set(a))
	b = []
	while len(a) > 1:
		for i in range(0, (len(a) - 1), 2):
			b.append(reduce_to_min(a[i], a[i + 1]))
		if len(a) % 2 == 1:
			b.append(a[-1])
		a = list(set(b))
		b = []
	return a[0] * length


def reduce_to_min(a, b):
	while a != b:
		if a > b:
			a -= b
		else:
			b -= a
	return a


# from fractions import gcd
# from functools import reduce
#
# def solution(a):
# 	return reduce(gcd, a) * len(a)