def service(score):
	first = int(score.split(":")[0])
	second = int(score.split(":")[1])
	if first + second < 42:
		if ((first + second) // 5) % 2 == 0:
			return "first"
		return "second"
	if ((first + second) // 2) % 2 == 0:
		return "first"
	return "second"
	
	

	