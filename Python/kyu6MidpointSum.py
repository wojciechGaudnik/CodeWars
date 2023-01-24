def midpoint_sum(ints):
	if len(ints) <= 2:
		return None
	for i in range(1, len(ints) - 1):
		if sum(ints[:i]) is  sum(ints[i + 1:]):
			return i
	return None
