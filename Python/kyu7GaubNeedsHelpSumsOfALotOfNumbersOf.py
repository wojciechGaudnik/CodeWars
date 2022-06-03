def f(n):
	if not isinstance(n, int) or n <= 0:
		return None
	return sum([i for i in range(0, n + 1)])
	# return sum([i for i in range(0, n + 1)]) if isinstance(n, int) or n > 0 else None
