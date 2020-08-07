import operator
import sys
from functools import reduce


def lowest_product(input):
	if len(input) < 4:
		return "Number is too small"
	if '0' in input:
		return 0
	max = sys.maxsize
	for sub in range(len(input) - 3):
		sum_numbers = reduce(operator.mul, [int(a) for a in input[sub:sub + 4]])
		if max > sum_numbers:
			max = sum_numbers
	return max
