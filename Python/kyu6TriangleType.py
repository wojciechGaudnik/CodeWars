# Should return triangle type:
#  0 : if triangle cannot be made with given sides
#  1 : acute triangle
#  2 : right triangle
#  3 : obtuse triangle
import math


def triangle_type(a, b, c):
	(a, b, c) = sorted([a, b, c])
	C = math.sqrt(a ** 2 + b ** 2)
	if a == 0 or b == 0 or c == 0:
		return 0
	elif C == c:
		return 2
	elif c >= a + b:
		return 0
	elif C < c:
		return 3
	return 1
