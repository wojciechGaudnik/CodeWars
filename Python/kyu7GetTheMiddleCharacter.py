def get_middle(s):
	if len(s) % 2 == 0:
		return str(s)[(len(s) // 2) - 1:(len(s) // 2) + 1]
	return str(s)[len(s) // 2]
