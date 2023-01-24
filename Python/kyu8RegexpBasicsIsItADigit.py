import re


def is_digit(n):
	if len(n) != 1:
		return False
	return re.match("^[0-9]{1}$", n, re.MULTILINE) is not None
