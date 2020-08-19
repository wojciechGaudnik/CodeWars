import operator
from functools import reduce
from itertools import zip_longest


def combine(*args):
	marker = 'marker'
	return [e for e in reduce(operator.iconcat, [list(e) for e in zip_longest(*args, fillvalue = marker)], []) if e != marker]

