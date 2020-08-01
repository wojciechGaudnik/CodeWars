def minimum_sum(values, n):
	if n == 0:
		return 0
	if n > len(values):
		n = len(values)
	return sum(n for n in sorted(values)[0:n])
	

def maximum_sum(values, n):
	if n == 0:
		return 0
	if n > len(values):
		n = len(values)
	return sum(n for n in sorted(values, reverse=True)[0:n])
