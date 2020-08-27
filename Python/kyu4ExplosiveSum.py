def exp_sum(n):
	n += 1
	M = [[0] * n for _ in range(n)]
	for i in range(0, n):
		M[i][0] = 1
	for si in range(1, n):
		for ni in range(1, n):
			if si > ni:
				M[si][ni] = M[si - 1][ni]
			else:
				WOS = M[si - 1][ni]
				WS = M[si][ni - si]
				M[si][ni] = WOS + WS
	n -= 1
	return M[n][n]


