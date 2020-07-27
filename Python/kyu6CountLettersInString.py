def letter_count(s):
	answer = {}
	for c in s:
		if c not in answer:
			answer[c] = 1
		else:
			answer[c] = answer[c] + 1
	answer = sorted(answer.items())
	return dict(answer)
