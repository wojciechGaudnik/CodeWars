def multiplication_table(size):
	answer = []
	for n in range(1, size + 1):
		answerPart = []
		for m in range(1, size + 1):
			answerPart.append(m * n)
		answer.append(answerPart)
	return answer
