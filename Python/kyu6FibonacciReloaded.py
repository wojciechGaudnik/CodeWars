def fib(n):
	first = 0
	second = 1
	while n > 1:
		first, second = second, first + second
		n -= 1
	return first