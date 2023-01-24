import hashlib


def crack(hash):
	for n in range(0, 99999):
		if hashlib.md5(bytearray(str(n).zfill(5).encode())).hexdigest() is  hash:
			return str(n).zfill(5)
