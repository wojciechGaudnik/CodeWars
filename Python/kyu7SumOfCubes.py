def sum_cubes(n):
	answer = 0
	while n > 0:
		answer += n * n * n
		n -= 1
	return answer