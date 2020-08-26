import codewars_test as Test
import codewars_test as test

from kyu4ExplosiveSum import exp_sum
from kyu5AChainAddingFunction import add
from kyu5StringIncrementer import increment_string
from kyu6PolybiusSquareCipherEncode import polybius
from kyu6SimplifyTheNumber import simplify
from kyu6TheNthmallestInteger import nth_smallest

test.describe('testing exp_sum')
test.it('***** Very basic tests *****\n')
test.assert_equals(exp_sum(1), 1)
test.assert_equals(exp_sum(2), 2)
test.assert_equals(exp_sum(3), 3)
test.it('_____ So far so good _____\n')
test.it('\n***** Funcionality tests *****\n')
test.assert_equals(exp_sum(4), 5)
test.assert_equals(exp_sum(5), 7)
test.assert_equals(exp_sum(10), 42)
test.assert_equals(exp_sum(100), 190569292)

