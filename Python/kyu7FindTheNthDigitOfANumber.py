def find_digit(num, nth):
	if len(str(abs(num))) < nth:
		return 0
	if nth <= 0:
		return -1
	return int(str(abs(num))[::-1][nth - 1])



print(find_digit([1,2,3], 1))