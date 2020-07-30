from binascii import hexlify

class Converter():
	@staticmethod
	def to_ascii(h):
		return bytearray.fromhex(h).decode()
	
	@staticmethod
	def to_hex(s):
		return str(hexlify(s.encode())).lstrip("b'").rstrip("'")
