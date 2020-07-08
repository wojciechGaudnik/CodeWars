def final_grade(exam, projects):
	data = [
		[90, 10, 100],
		[75, 5, 90],
		[50, 2, 75]
	]
	if exam >= data[0][0] or projects >= data[0][1]:
		return data[0][2]
	elif exam >= data[1][0] and projects >= data[1][1]:
		return data[1][2]
	elif exam >= data[2][0] and projects >= data[2][1]:
		return data[2][2]
	return 0


