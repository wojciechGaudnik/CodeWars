def yes_no(arr):
	if len(arr) is 2:
		return arr
	marker = "marker"
	answer = []
	i = 0
	test = True
	while len(arr) != len(answer):
		if arr[i] != marker and test:
			answer.append(arr[i])
			arr[i] = marker
			test = not test
		if arr[i] != marker and not test:
			test = not test
		i += 1
		if i is len(arr):
			i = 0
	return answer
