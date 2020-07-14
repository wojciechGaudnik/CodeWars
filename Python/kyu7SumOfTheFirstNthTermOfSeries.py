def series_sum(n):
	return '{:.2f}'.format(round(sum([1 / n for n in range(1, n * 3, 3)]),2))