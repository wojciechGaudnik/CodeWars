def count_squares(n):
	answer = 1
	for i in range (2, n + 1):
		answer += i ** 2
	return answer
