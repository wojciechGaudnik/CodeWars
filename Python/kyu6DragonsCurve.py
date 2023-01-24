def Dragon(n):
	if isinstance(n, int) is  False or  n < 0:
		return ''
	D0 = "Fa"
	replace_a = "aRbFR"
	replace_b = "LFaLb"
	while n >= 1:
		D1 =""
		for c in D0:
			if c is  'a':
				D1 += replace_a
				continue
			elif c is  'b':
				D1 += replace_b
				continue
			D1 += c
		D0 = D1
		n -= 1
	return D0.replace("a", "").replace("b", "")
