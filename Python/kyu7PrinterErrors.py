import re


def printer_error(s):
	return f'{len(re.sub(r"[a-m]", "", s))}/{len(s)}'
