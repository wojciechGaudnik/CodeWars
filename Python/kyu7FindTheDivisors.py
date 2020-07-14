def divisors(integer):
	answer = [n for n in range(2, integer) if integer % n == 0]
	if len(answer) == 0:
		return f"{integer} is prime"
	return answer