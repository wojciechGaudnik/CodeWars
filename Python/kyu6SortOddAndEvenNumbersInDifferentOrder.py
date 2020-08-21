def sort_array(a):
	odd = []
	odd_i = []
	even = []
	even_i = []
	for i, e in enumerate(a):
		if e % 2 == 0:
			even.append(e)
			even_i.append(i)
		else:
			odd.append(e)
			odd_i.append(i)
	odd.sort()
	even.sort(reverse=True)
	for i, v in zip(odd_i, odd):
		a[i] = v
	for i, v in zip(even_i, even):
		a[i] = v
	return a
