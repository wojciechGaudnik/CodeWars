def is_isogram(string):
	return len(string) is len(set(string.lower()))
