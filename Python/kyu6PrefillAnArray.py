def prefill(n, v = None):
	try:
		n = int(n)
	except:
		raise TypeError(f'{n} is invalid')
	return [v] * n


