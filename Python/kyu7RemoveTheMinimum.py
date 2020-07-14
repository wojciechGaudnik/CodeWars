def remove_smallest(numbers):
	numbers_buff = numbers.copy()
	if len(numbers_buff) == 0:
		return []
	numbers_buff.remove(min(numbers))
	return numbers_buff
