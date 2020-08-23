from math import floor


def zero(n=None):
	if n is None:
		return 0
	return n(0)


def one(n=None):
	if n is None:
		return 1
	return n(1)


def two(n=None):
	if n is None:
		return 2
	return n(2)


def three(n=None):
	if n is None:
		return 3
	return n(3)


def four(n=None):
	if n is None:
		return 4
	return n(4)


def five(n=None):
	if n is None:
		return 5
	return n(5)


def six(n=None):
	if n is None:
		return 6
	return n(6)


def seven(n=None):
	if n is None:
		return 7
	return n(7)


def eight(n=None):
	if n is None:
		return 8
	return n(8)


def nine(n=None):
	if n is None:
		return 9
	return n(9)


def plus(n):
	return lambda n_in: n_in + n


def minus(n):
	return lambda n_in: n_in - n


def divided_by(n):
	return lambda n_in: floor(n_in / n)


def times(n):
	return lambda n_in: n_in * n
