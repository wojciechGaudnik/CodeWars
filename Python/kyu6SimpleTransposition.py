def simple_transposition(text):
	return "".join([n if i % 2 == 0 else '' for i, n in enumerate(text)] + [n if i % 2 == 1 else '' for i, n in enumerate(text)])
