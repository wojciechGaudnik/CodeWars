def solution(digits):
	max = 0
	for i ,_ in enumerate(digits[:-4]):
		if max < int(digits[i:i+5]):
			max = int(digits[i:i+5])
	return max

