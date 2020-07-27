class Cipher(object):
	def __init__(self, map1, map2):
		self.map1 = map1
		self.map2 = map2
	
	def encode(self, s):
		print("--->" + s)
		print("--->" + self.map1)
		print("--->" + self.map2)
		return "".join([self.map2[self.map1.index(c)] if str(c).islower() else c for c in s])
	
	def decode(self, s):
		print(s + "<---")
		print(self.map1 + "<---")
		print(self.map2 + "<---")
		return "".join([self.map1[self.map2.index(c)] if str(c).islower() else c for c in s])
