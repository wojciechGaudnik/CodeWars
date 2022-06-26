class Dog(object):
	def __init__(self, name, breed, sex, age):
		self.name  = name
		self.breed = breed
		self.sex   = sex
		self.age   = age
		
def bark(self):
	print("Woof!")

setattr(Dog, 'bark', bark)
