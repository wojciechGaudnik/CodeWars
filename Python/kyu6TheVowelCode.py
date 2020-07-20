def encode(st):
	vowels = "aeiou"
	return ''.join([str(vowels.index(f'{l}') + 1) if l in vowels else l for l in st])

def decode(st):
	numbers = "12345"
	vowels = "aeiou"
	return ''.join([vowels[int(l) - 1] if l.isdigit() else l for l in st])

print(encode("hello"))

for l in "1sd1":
	print(l.isdigit())