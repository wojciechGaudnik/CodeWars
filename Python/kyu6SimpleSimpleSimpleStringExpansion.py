def string_expansion(s):
	if s == '':
		return s
	answer = ''
	multi = 1
	for c in s:
		if str(c).isdigit():
			multi = int(c)
			continue
		answer += c * multi
	return answer
