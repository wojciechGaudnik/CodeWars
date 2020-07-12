def high_and_low(numbers):
	numbers = [int(n) for n in str(numbers).split(" ")]
	return f'{str(max(numbers))} {str(min(numbers))}'
