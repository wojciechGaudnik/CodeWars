def solve(st, idx):
	answer = 0
	if st[idx] != '(':
		return -1
	for i, c in enumerate(st[idx + 1:]):
		if c == ')' and answer == 0:
			return i + idx + 1
		if c == '(':
			answer += 1
		if c == ')':
			answer -= 1
	return answer if answer else -1
