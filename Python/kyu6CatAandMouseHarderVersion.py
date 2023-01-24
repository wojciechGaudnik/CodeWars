import re


def cat_mouse(x,j):
	if 'm' not in x or 'C' not in x or 'D' not in x:
		return "boring without all three"
	if re.search(r"m(.)*C", x) is not None:
		x = "".join(reversed(x))
	if re.search(r"C.{," + str(j) + "}m", x) is None:
		return "Escaped!"
	if re.search(r"C\.*D", x) is not None:
		return "Protected!"
	return "Caught!"
