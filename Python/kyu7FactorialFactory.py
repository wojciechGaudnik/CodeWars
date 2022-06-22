def factorial(n):
	if n < 0:
		return None
	return 1 if n <= 1 else n * factorial(n - 1)
