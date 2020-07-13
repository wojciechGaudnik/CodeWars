def nb_year(p0, percent, aug, p):
	i = 0
	while(p0 < p):
		p0 += p0 * (percent / 100) + aug
		i += 1
	return i