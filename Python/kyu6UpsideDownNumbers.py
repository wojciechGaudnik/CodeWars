def solve(a, b):
	upside_numbers = {'0':"0", '1':"1", '6':"9", '8':"8", '9':"6"}
	answer = 0
	for number in range(a,b):
		test = True
		for n in str(number):
			if n not in upside_numbers.keys():
				test = False
				break
		if test:
			upside_number = int("".join([upside_numbers[n] for n in str(number)[::-1]]))
			if number == upside_number:
				answer += 1
	return answer
