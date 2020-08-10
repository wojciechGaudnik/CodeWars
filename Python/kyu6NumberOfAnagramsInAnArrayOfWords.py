from collections import Counter
from numpy import math as np_math


def anagram_counter(words):
	return int(sum(map(
		lambda n: np_math.factorial(n) / (np_math.factorial(2) * np_math.factorial(n - 2)),
		[n for n in Counter([''.join(sorted(word))for word in words]).values() if n > 1])))
