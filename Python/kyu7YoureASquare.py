import math


def is_square(n):
	if n < 0 :
		return False
	return math.sqrt(n) % 1 == 0

