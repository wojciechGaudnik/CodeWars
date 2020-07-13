import math


def find_next_square(sq):
	if math.sqrt(sq) % 1 != 0:
		return -1
	sq += 1
	while math.sqrt(sq) % 1 != 0:
		sq += 1
	return sq
