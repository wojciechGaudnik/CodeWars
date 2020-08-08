def left_riemann(f, n, a, b):
	dx = (b - a) / float(n)
	return round(dx * (sum([f(a + i * dx) for i in range(0, n)])), 2)
