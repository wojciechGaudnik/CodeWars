def reverse(seq):
	if len(seq) == 0:
		return seq
	if len(seq) % 2 == 0:
		for b, e in zip(range(0, len(seq) // 2), range(len(seq) - 1, (len(seq) // 2) - 1 , -1)):
			print(" " + str(b) + " " + str(e))
			(seq[b], seq[e]) = (seq[e], seq[b])
	elif len(seq) % 2 == 1:
		for b, e in zip(range(0, len(seq) // 2), range(len(seq) - 1, (len(seq) // 2) - 2 , -1)):
			print(" " + str(b) + " " + str(e))
			(seq[b], seq[e]) = (seq[e], seq[b])
	return seq
