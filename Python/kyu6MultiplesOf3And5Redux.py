from fractions import Fraction


def solution(number):
	number = number - 1
	last_three = number
	threes = number // 3
	last_five = number
	fives = number // 5
	last_fifteen = number
	fifteens = number // 15
	while last_three % 3 != 0:
		last_three -= 1
	while last_five % 5 != 0:
		last_five -= 1
	while last_fifteen % 15 != 0:
		last_fifteen -= 1
	two = Fraction(2)
	a = ((last_three * threes) / two + threes * Fraction(0.5 * 3))
	b = ((last_five * fives) / two + fives * Fraction(0.5 * 5))
	c = (last_fifteen * fifteens) / two + fifteens * Fraction(0.5 * 15)
	return (a + b - c)

