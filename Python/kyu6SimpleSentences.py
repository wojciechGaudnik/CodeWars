def make_sentences(parts):
	return "".join([" " + c if c != ',' and c != '.' else c for c in parts]).lstrip().rstrip(' ').rstrip('.') + "."

