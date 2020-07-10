def sale_hotdogs(n):
	if(n < 5):
		return n * 100
	if(n >= 5 and n < 10):
		return n * 95
	if(n >= 10):
		return n * 90