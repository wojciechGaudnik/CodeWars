def words_to_marks(s):
	return sum([ord(letter) - 96 for letter in s])
