from functools import reduce


def ride(group,comet):
	group = reduce(lambda a, b: a * b, [ord(e) - 64 for e in group])
	comet = reduce(lambda a, b: a * b, [ord(e) - 64 for e in comet])
	return "GO" if group % 47 == comet % 47 else "STAY"
