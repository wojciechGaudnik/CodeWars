def simplify(number):
	if number == 0:
		return ""
	if len(str(number)) == 1:
		return str(number)
	answer = str(number)[-1] if str(number)[-1] != '0' else ""
	for i, d in enumerate(str(number)[len(str(number)) - 2::-1]):
		i += 1
		if int(d) > 0:
			answer = d + "*" + str(10 ** i) + "+" + answer
	return answer.rstrip('+')

