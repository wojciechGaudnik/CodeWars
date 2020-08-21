def is_happy(n):
	all_numbers = set()
	while n != 1:
		n = sum([int(e) ** 2 for e in str(n)])
		if n in all_numbers:
			return False
		all_numbers.add(n)
	return True
