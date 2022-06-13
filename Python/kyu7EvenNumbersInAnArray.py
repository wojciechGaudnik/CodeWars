def even_numbers(arr,n):
	return [e for e in arr if e % 2 == 0][-n:]
