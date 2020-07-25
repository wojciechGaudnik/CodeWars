def string_transformer(s):
	return " ".join([word.swapcase() for word in reversed(s.split(" "))])
