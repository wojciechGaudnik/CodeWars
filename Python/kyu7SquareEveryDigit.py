def square_digits(num):
	return int(str.join("", [str(int(n) * int(n)) for n in str(num)]))
