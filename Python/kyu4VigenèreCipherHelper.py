class VigenereCipher(object):
	def __init__(self, key, alphabet):
		self.key = key
		self.alphabet = alphabet * 2
	
	def encode(self, text):
		answer = ""
		key_long = self.key * ((len(text) // len(self.key)) + 1)
		for i, l in enumerate(text):
			if l in self.alphabet:
				answer += self.alphabet[self.alphabet.index(l) + self.alphabet.index(key_long[i])]
			else:
				answer += l
		return answer
	
	
	def decode(self, text):
		answer = ""
		key_long = self.key * ((len(text) // len(self.key)) + 1)
		for i, l in enumerate(text):
			if l in self.alphabet:
				answer += self.alphabet[self.alphabet.index(l) - self.alphabet.index(key_long[i])]
			else:
				answer += l
		return answer
