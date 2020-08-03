def more_zeros(s):
	answer = {}
	for c in s:
		if str(bin(ord(c)))[2:].count('0') > str(bin(ord(c)))[2:].count('1'):
			answer[c] = ''
	return list(answer.keys())
