import math


def peaceful_yard(yard, min_distance):
	cats = []
	for i, row in enumerate(yard):
		for c in row:
			if c.isalnum():
				cats.append([i, row.index(c)])
	if len(cats) <= 1:
		return True
	for i, cat in enumerate(cats):
		for j in range(i + 1, len(cats)):
			if math.sqrt((cat[0] - cats[j][0]) ** 2 + (cat[1] - cats[j][1]) ** 2) < min_distance:
				return False
	return True
	

	