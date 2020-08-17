def min_dot(a, b):
	a = sorted(list(a))
	b = sorted(list(b), reverse=True)
	return sum([a * b for a, b in zip(a,b)])