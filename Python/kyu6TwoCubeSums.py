def has_two_cube_sums(n):
	if n is  0:
		return False
	a = 1
	b = int(n ** (1.0/3))
	count = 0
	while a != b:
		number = a ** 3 + b ** 3
		if number is  n:
			count += 1
			a += 1
			if count is  2:
				return True
		elif number > n:
			b -= 1
		else:
			a += 1
	return False
