import re


class Robot:
	words = set()
	
	def __init__(self) -> None:
		super().__init__()
		self.words = set([s.lower() for s in "I do not understand the input I already know the word Thank you for teaching me ".split()])
		
	def learn_word(self, param):
		print("--->" + param + "<---")
		param_original = param
		param = param.lower()
		if len(param) == 0 or len(re.findall(r"[^a-z]", param)):
			return 'I do not understand the input'
		if param in self.words:
			return f'I already know the word {param_original}'
		self.words.add(param)
		return f'Thank you for teaching me {param_original}'
