def reindeer(presents):
	if presents > 180:
		raise ValueError
	answer = 2
	while presents > 0:
		answer += 1
		presents -= 30
	return answer
