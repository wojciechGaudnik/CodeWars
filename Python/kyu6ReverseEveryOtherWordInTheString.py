def reverse_alternate(string):
	return " ".join([word if i % 2 == 0 else "".join(reversed(word)) for i, word in enumerate(string.split())])
