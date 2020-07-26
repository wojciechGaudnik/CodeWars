def f(n, m):
	if n == 0:
		return 0
	if m > n:
		m = n
		answer = ((m * m) - m) // 2
		answer = answer * (n // m) + n
		n = n % m
		return answer + f(n, m) + n
	elif n >= m:
		answer = ((m * m) - m) // 2
		answer = answer * (n // m)
		n = n % m
		return answer + f(n, m)
