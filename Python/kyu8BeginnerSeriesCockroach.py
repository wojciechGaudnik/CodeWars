import math


def cockroach_speed(s):
	return math.floor((s * 100000) / 3600)

print(cockroach_speed(1.08))