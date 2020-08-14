def on_line(points):
	y = 1
	x = 0
	if len(points) <= 2:
		return True
	all_x = points[0][x]
	all_y = points[0][y]
	test = True
	for point in points[1:]:
		if point[x] != all_x:
			test = False
			break
	if test:
		return True
	for point in points[1:]:
		if point[y] != all_y:
			test = False
			break
	if test:
		return True
	if (points[1][x] - points[0][x]) != 0:
		a = (points[1][y] - points[0][y]) / (points[1][x] - points[0][x])
	else:
		a = 0
	b = points[0][y] - a * points[0][x]
	for point in points[2:]:
		if point[y] != a * point[x] + b:
			return False
	return True
	
