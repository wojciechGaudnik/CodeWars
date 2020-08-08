def uniq(seq):
	if len(seq) <= 1:
		return seq
	answer = [seq[0], ]
	for e in seq[1:]:
		if e != answer[-1]:
			answer.append(e)
	return answer

# print(''.join(uniq([None,'a','a'])))


