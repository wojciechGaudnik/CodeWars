class Harshad:
	@staticmethod
	def is_valid(number):
		return number % sum([int(n) for n in str(number)]) == 0
	
	@staticmethod
	def get_next(number):
		number += 1
		while not Harshad.is_valid(number):
			number += 1
		return number
	
	@staticmethod
	def get_series(count, start=0):
		answer = [Harshad.get_next(start),] if start != 0 else [1,]
		while len(answer) != count:
			answer.append(Harshad.get_next(answer[-1]))
		return answer
	
