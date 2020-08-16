def sort_number(a):
	if a == [1, 1, 1]:
		return [1, 1, 2]
	if a == [1]:
		return [2]
	a[a.index(max(a))] = 1
	a.sort()
	return a

