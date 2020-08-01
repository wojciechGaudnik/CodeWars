def split_integer(num, parts):
	answer = [num // parts for _ in range(parts)]
	num_sum = num - sum(answer)
	if num_sum != 0:
		for n in range(len(answer) - 1, len(answer) - 1 - (num_sum), -1):
			answer[n] += 1
	return answer

# print(split_integer(20, 6))
print(split_integer(11, 3))