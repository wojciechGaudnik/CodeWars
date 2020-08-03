def first_dup(s):
	for c in s:
		if str(s).count(c) > 1:
			return c
	return None
