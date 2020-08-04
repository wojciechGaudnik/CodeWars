def solution(a):
	print(a)
	count = 1
	i = a[0]
	a[0] = 'x'
	while 0 < i < len(a) and a[i] != 'x':
		last_i = i
		i += a[i]
		a[last_i] = 'x'
		count += 1
	if i < 0 or i >= len(a):
		return count
	return -1
