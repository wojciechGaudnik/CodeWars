def multiplication_table(row, col):
	answer = []
	start = 1
	while start <= row:
		part = []
		for i in range(1, col + 1):
			part.append(i * start)
		answer.append(part)
		start += 1
	return answer
