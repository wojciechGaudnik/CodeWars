import re


def cat_mouse(x,j):
	if 'm' not in x or 'C' not in x or 'D' not in x:
		return "boring without all three"
	if re.search(r"m(.)*C", x) != None:
		x = "".join(reversed(x))
	cat_index = str(x).find("C")
	for c in x[cat_index + 1:]:
		j -= 1
		if j == 0 and c != "m":
			return "Escaped!"
		if c == "D":
			return "Protected!"
		if j == 0:
			return "Escaped!"
		if c == "m" and j > 0:
			return "Caught!"
	return "Escaped!"
		


# print(cat_mouse("....m..........D.....C...", 12))
print(cat_mouse("......m..........C...D...", 0))
