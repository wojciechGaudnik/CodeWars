def list_animals(animals):
	answer = ''
	for i, animal in enumerate(animals, start=1):
		answer += str(i) + ". " + animal + '\n'
	return answer
