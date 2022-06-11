def flatten(lst):
	answer = []
	for e in lst:
		if isinstance(e, list):
			answer = answer + e
		else:
			answer.append(e)
	return answer

