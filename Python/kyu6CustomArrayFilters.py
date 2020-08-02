import builtins

class ExtendedList(list):
	def even(self):
		return list(filter(lambda n : str(n).isdigit() and n % 2 == 0, self))
	def odd(self):
		return list(filter(lambda n : str(n).isdigit() and n % 2 == 1, self))
	def under(self, m):
		return list(filter(lambda n : str(n).isdigit() and n < m, self))
	def over(self, m):
		return list(filter(lambda n : str(n).isdigit() and n > m, self))
	def in_range(self, min, max):
		return list(filter(lambda n : str(n).isdigit() and n >= min and n <= max, self))

builtins.list = ExtendedList


