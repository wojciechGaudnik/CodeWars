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

	
	
# def exp_sum3(n):
# 	return sum(accel_asc(n))
#
# def accel_asc(n):
# 	a = [0 for _ in range(n + 1)]
# 	k = 1
# 	y = n - 1
# 	while k != 0:
# 		x = a[k - 1] + 1
# 		k -= 1
# 		while 2 * x <= y:
# 			a[k] = x
# 			y -= x
# 			k += 1
# 		l = k + 1
# 		while x <= y:
# 			a[k] = x
# 			a[l] = y
# 			yield 1
# 			x += 1
# 			y -= 1
# 		a[k] = x + y
# 		y = x + y - 1
# 		yield 1
#
# print(sum(accel_asc(5)))
#
# # for x in range(1, 30)):
# # 	print(str(exp_sum(x)) + " " + str(exp_sum(x) - exp_sum(x - 1)))
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#
#






	
# def exp_sum2(n):
# 	answer = set()
# 	answer.add((n, ))
# 	for x in range(1, n):
# 		for y in exp_sum2(n - x):
# 			answer.add(tuple(sorted((x, ) + y)))
# 	return answer
#
#
# def exp_sum(n):
# 	if n == 0:
# 		return 1
# 	S = 0
# 	J = n - 1
# 	k = 2
# 	while J >= 0:
# 		T = exp_sum(J)
# 		S = S + T if (k // 2) % 2 == 1 else S - T
# 		J -= k if k % 2 == 1 else k // 2
# 		k += 1
# 	return S

