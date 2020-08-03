def alphabetized(s):
	answer = []
	for c in s:
		if c.isalnum():
			answer.append([c.lower(), c])
	answer = sorted(answer, key=lambda c: c[0])
	return "".join([c[1] for c in answer])
