def find_children(dancing_brigade):
	if dancing_brigade == "":
		return ""
	dancing_brigade = sorted(dancing_brigade.lower())
	last = dancing_brigade[0]
	dancing_brigade[0] = last.upper()
	for i, c in enumerate(dancing_brigade[1:], 1):
		if last != c:
			last = c
			dancing_brigade[i] = last.upper()
	return "".join(dancing_brigade)
