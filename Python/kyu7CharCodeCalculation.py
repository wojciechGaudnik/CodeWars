def calc(x):
	total1 = ''.join([str(ord(letter)) for letter in x])
	total2 = total1.replace("7", "1")
	total1sum = sum([int(number) for number in total1])
	total2sum = sum([int(number) for number in total2])
	return total1sum - total2sum