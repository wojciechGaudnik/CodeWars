def circularly_sorted(arr):
	if is_asc(arr):
		return True
	count = len(arr)
	while count > 0:
		arr = [arr[-1], ] + arr[:-1]
		if is_asc(arr):
			return True
		count -= 1
	return False
	
def is_asc(arr):
	for i in range(len(arr) - 1):
		if arr[i] > arr[i + 1]:
			return False
	return True
