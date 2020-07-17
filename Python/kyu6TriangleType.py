# Should return triangle type:
#  0 : if triangle cannot be made with given sides
#  1 : acute triangle
#  2 : right triangle
#  3 : obtuse triangle
import math


def triangle_type(a, b, c):
	if a == b and b == c:
		return 1
	elif c == math.sqrt(a ** a + b ** b):
		return 2
	elif a + b >= c or b + c >= a or c + a >= b:
		return 0
	return 3
	
a = 8
b = 5
c = 7
print(math.sqrt(math.pow(a, 2) + math.pow(b, 2)))
print(math.sqrt(math.pow(b, 2) + math.pow(c, 2)))
print(math.sqrt(math.pow(c, 2) + math.pow(a, 2)))