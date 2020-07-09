import re

def no_boring_zeros(n):
	if n == 0:
		return 0
	m = str(n)
	return int(re.sub(r'(0)*$', "", m))

