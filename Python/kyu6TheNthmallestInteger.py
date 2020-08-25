def nth_smallest(arr, n):
	arr = sorted(set(arr))
	return arr[n - 1] if len(arr) >= n else None
