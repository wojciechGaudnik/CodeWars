def number_to_ordinal(n):
	if n == 0:
		return "0"
	if(n > 20):
		n = str(n)
		if n[-2:] == "11":
			return n + "th"
		if n[-1] == "1":
			return n + "st"
		if n[-2:] == "12":
			return n + "th"
		if n[-1] == "2":
			return n + "nd"
		if n[-2:] == "13":
			return n + "th"
		if n[-1] == "3":
			return n + "rd"
		return n + "th"
	first20 = ['1st', '2nd', '3rd', '4th', '5th', '6th', '7th', '8th', '9th', '10th',
		'11th', '12th', '13th', '14th', '15th', '16th', '17th', '18th', '19th',
		'20th']
	return first20[n - 1]
	# return (lambda n: f'{n}'+'tsnrhtdd'[n % 5 * (n % 100 ^ 15 > 4 > n % 10)::4])(n)

