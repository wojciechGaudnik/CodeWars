import operator
from collections import Counter
from functools import reduce


def solve(arr):
	return reduce(operator.add, [[e[0]] * e[1] for e in (sorted(Counter(arr).items(), key=lambda x: (-x[1], x[0])))])