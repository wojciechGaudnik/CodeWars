def two_sort(array):
	array = sorted(array)
	answer = ""
	for one in array[0]:
		answer += one + "***"
	return answer.rstrip("*")

# return '***'.join(min(lst))


