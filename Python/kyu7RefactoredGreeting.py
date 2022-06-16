
class Person:
	
	def __init__(self, my_name=None):
		self.name = my_name
		
	def greet(self, your_name):
		return "Hello %s, my name is %s" % (your_name, self.name)
