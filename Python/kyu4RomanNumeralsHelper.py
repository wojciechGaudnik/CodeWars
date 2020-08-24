class RomanNumerals():
	
	dic_from = {"M": 1000, "CM": 900, "D": 500, "CD": 400, "C": 100, "XC": 90, "L": 50, "XL": 40, "X": 10, "IX": 9, "V": 5, "IV": 4, "I": 1}
	
	@classmethod
	def to_roman(cls, param):
		dic_to_rom = dict([(k, v) for v, k in RomanNumerals.dic_from.items()])
		answer = ""
		while param > 0:
			for k, v in dic_to_rom.items():
				while param // k > 0:
					answer += v
					param -= k
		return answer
		
	
	@classmethod
	def from_roman(cls, param):
		answer = 0
		i = 0
		for k, v in RomanNumerals.dic_from.items():
			while i + len(k) <= len(param) and param[i: i + len(k)] == k:
				answer += v
				i += len(k)
		return answer
