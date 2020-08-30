import re

#asalamon solution from java
class PokerHand(object):
	RESULT = ["Loss", "Tie", "Win"]
	rank = 0
	value = ""
	hand = ""
	
	def __init__(self, hand):
		self.hand = hand
		drill, flush, full1, full2, pair, poker, straight, two_pair = self.set_hand(hand)
		self.set_rank_value(drill, flush, full1, full2, pair, poker, straight, two_pair)
	
	def set_rank_value(self, drill, flush, full1, full2, pair, poker, straight, two_pair):
		if (straight and flush):
			self.value = self.value.replace("e5432", "54321")
			self.rank = 8
		elif poker:
			self.rank = 7
		elif full1:
			self.rank = 6
		elif full2:
			self.value = self.value[3:5] + self.value[0:3]
			self.rank = 6
		elif flush:
			self.rank = 5
		elif straight:
			self.value = self.value.replace("e5432", "54321")
			self.rank = 4
		elif drill:
			self.value = self.value.replace("(.*)(\w)\2\2(.*)", "$2$2$2$1$3")
			self.rank = 3
		elif two_pair:
			self.value = self.value.replace("(.*)(\w)\2(\w)\3(.*)", "$2$2$3$3$1$4")
			self.rank = 2
		elif pair:
			self.value = self.value.replace("(.*)(\w)\2(.*)", "$2$2$1$3")
			self.rank = 1
		else:
			self.rank = 0
	
	def set_hand(self, hand):
		hand = str(hand).replace("T", "a").replace("J", "b").replace("Q", "c").replace("K", "d").replace("A", "e")
		hand = " ".join(list(sorted([e for e in hand.split()])))
		self.value += hand[12] + hand[9] + hand[6] + hand[3] + hand[0]
		flush = True if re.match(r".(\w) .\1 .\1 .\1 .\1", hand) else False
		poker = True if re.match(r".*(\w)\w \1\w \1\w \1\w.*", hand) else False
		full1 = True if re.match(r".*(\w)\w \1\w (\w)\w \2\w \2\w.*", hand) else False
		full2 = True if re.match(r".*(\w)\w \1\w \1\w (\w)\w \2\w.*", hand) else False
		drill = True if re.match(r".*(\w)\w \1\w \1\w.*", hand) else False
		two_pair = True if re.match(r".*(\w)\w \1\w (\w)\w \2\w.*", hand) else False
		pair = True if re.match(r".*(\w)\w \1\w.*", hand) else False
		straight = False
		straights = [r'2..3..4..5..6.',
			r"3..4..5..6..7.",
			r"4..5..6..7..8.",
			r"5..6..7..8..9.",
			r"6..7..8..9..a.",
			r"7..8..9..a..b.",
			r"8..9..a..b..c.",
			r"9..a..b..c..d.",
			r"a..b..c..d..e.",
			r"2..3..4..5..e.",
		]
		for reg in straights:
			if re.match(reg, hand):
				straight = True
				break
		return drill, flush, full1, full2, pair, poker, straight, two_pair
	
	def compare_with(self, other):
		if other.rank - self.rank != 0:
			return self.RESULT[0] if other.rank > self.rank else self.RESULT[2]
		else:
			if other.value == self.value:
				return self.RESULT[1]
			else:
				return self.RESULT[0] if other.value > self.value else self.RESULT[2]
