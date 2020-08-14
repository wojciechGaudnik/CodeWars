def sort_string(s, ordering):
	ordering = "".join(dict.fromkeys(ordering))
	return "".join(sorted("".join(c for c in s if c in ordering), key=lambda x:ordering.index(x))) + \
	       "".join(c for c in s if c not in ordering)
