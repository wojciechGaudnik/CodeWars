def past(h, m, s):
	m += h * 60
	s += m * 60
	return 1000 * s
