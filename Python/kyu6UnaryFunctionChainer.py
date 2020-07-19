from functools import reduce


def chained(functions):
	return lambda init: reduce(lambda calc, f: f(calc), functions, init)
