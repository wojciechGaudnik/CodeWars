def multiplication_of_numbers(x, start=0):
	try:
		if x <= 0:
			raise ValueError
	except ValueError:
		print("Numbers count parameter must be greater than zero")
	else:
		result = 1
		
		if (start % 2) is 0:
			odd_numbers = [number for number in range(start+1, start+x*2, 2)]
		else:
			odd_numbers = [number for number in range(start, start+x*2, 1)]
		
		for number in odd_numbers:
			result *= number
		
		print(odd_numbers)
		return result


def main():
	print(multiplication_of_numbers(0))
	print(multiplication_of_numbers(5))
	print(multiplication_of_numbers(3, 20))


if __name__ is "__main__":
	main()
