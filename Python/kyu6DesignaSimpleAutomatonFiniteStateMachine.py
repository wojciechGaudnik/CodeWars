class Automaton(object):
	
	def __init__(self):
		self.states = []
	
	def read_commands(self, commands):
		state = 1
		for c in commands:
			c = int(c)
			if state == 1:
				state = 2 if c == 1 else state
				continue
			if state == 2:
				state = 3 if c == 0 else state
				continue
			if state == 3:
				state = 2
		return True if state == 2 else False

my_automaton = Automaton()

