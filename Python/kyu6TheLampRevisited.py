class Lamp:
	def __init__(self, color):
		self.on = False
		self.color = color
	
	def state(self):
		if self.on:
			return "The lamp is on."
		return "The lamp is off."
		
	
	def toggle_switch(self):
		self.on = not self.on