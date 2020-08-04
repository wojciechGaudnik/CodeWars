import re


def money_value(s):
	try:
		return float(re.sub(r'[\s$]', '', s))
	except ValueError:
		return 0
