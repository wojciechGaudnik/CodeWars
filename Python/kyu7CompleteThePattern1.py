def pattern(number):
	return "" if number <= 0 else '\n'.join([str(n) * n for n in range(1, number + 1)])
