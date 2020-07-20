def is_int_array(arr):
	if arr == "" or arr == None:
		return False
	try:
		for n in arr:
			N = int(n)
			if N - n != 0:
				return False
	except:
		return False
	return True
