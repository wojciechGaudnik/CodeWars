def fizz_buzz_custom(string_one="Fizz", string_two="Buzz", num_one=3, num_two=5):
	answer = []
	for n in range(1, 101):
		first = n % num_one == 0
		second = n % num_two == 0
		if first and second:
			answer.append(string_one + string_two)
			continue
		if first:
			answer.append(string_one)
			continue
		if second:
			answer.append(string_two)
			continue
		answer.append(n)
	return answer
	
