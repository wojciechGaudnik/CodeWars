def run_length_encoding(s):
	if len(s) == 0:
		return []
	answer = []
	s += '``'
	last = s[0]
	count = 1
	for c in s[1:]:
		if c == last:
			count += 1
		else:
			answer.append([count, last])
			last = c
			count = 1
	return answer
	


print(run_length_encoding("aaaaaaaaaaa"))