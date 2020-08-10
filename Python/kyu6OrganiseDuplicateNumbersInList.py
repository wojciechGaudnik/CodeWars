from collections import Counter

def group(arr):
	return [[k] * int(v) for k, v in Counter(arr).items()]
		
