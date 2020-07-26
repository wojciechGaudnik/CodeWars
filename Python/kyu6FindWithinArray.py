def find_in_array(seq, predicate):
	for i, s in enumerate(seq):
		if predicate(s, i):
			return i
	return -1
