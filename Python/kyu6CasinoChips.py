def solve(arr):
	arr.sort()
	return arr[0] + arr[1] if arr[0] + arr[1] <= arr[2] else int((arr[0] + arr[1] + arr[2]) / 2)
