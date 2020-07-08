def reverse_list(l):
	answer = []
	for e in l:
		answer.insert(0, e)
	return answer
	# return l[::-1]
