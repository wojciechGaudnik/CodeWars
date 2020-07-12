def accum(s):
	answer = ""
	i = 0
	for c in str(s.upper()):
		answer += c
		answer += ''.join(c.lower() * i)
		answer += '-'
		i += 1
	return answer.rstrip('-')
	# return '-'.join(c.upper() + c.lower() * i for i, c in enumerate(s))
