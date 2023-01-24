def power_of_two(x):
	test = 1
	while test <= x:
		if test is x:
			return True
		else:
			test = test << 1
	return False
