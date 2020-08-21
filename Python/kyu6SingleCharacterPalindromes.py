def solve(s):
	s_copy = s
	if s == s[::-1]:
		return "OK"
	for i in range(len(s)):
		s = s_copy[0:i] + s_copy[i + 1:]
		if s == s[::-1]:
			return "remove one"
	return "not possible"
