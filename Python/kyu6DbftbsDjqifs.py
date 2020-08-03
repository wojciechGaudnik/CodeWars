def encryptor(key, message):
	print(message)
	alphabet = "".join(chr(c) for c in range(65,91)) * 2
	if key < 0:
		alphabet = "".join(reversed(alphabet))
		key = abs(key)
	key %= 26
	answer = ""
	for c in message:
		if c.isupper():
			answer += alphabet[alphabet.index(c) + key]
		elif c.islower():
			answer += alphabet[alphabet.index(c.upper()) + key].lower()
		else:
			answer += c
	return answer
