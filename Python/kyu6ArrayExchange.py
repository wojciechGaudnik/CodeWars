def exchange_with(a, b):
	marker = 'marker'
	if len(a) < len(b):
		add = len(b) - len(a)
		while add:
			a.append(marker)
			add -= 1
	elif len(a) > len(b):
		add = len(a) - len(b)
		while add:
			b.append(marker)
			add -= 1
	for i, ab in enumerate(zip(a[::-1], b[::-1])):
		a[i], b[i] = ab[1], ab[0]
	a_marker = a.count(marker)
	b_marker = b.count(marker)
	if a_marker:
		while a_marker != 0:
			a.remove(marker)
			a_marker -= 1
	if b_marker:
		while b_marker != 0:
			b.remove(marker)
			b_marker -= 1
	# a[:], b[:] = b[::-1], a[::-1]

