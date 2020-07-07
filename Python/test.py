import codewars_test as Test
import codewars_test as test

from kyu8CoefficientsOfTheQuadraticEquation import quadratic

test.assert_equals(quadratic(0,1), (1, -1, 0))
test.assert_equals(quadratic(4,9), (1, -13, 36))
test.assert_equals(quadratic(2,6), (1, -8, 12))
test.assert_equals(quadratic(-5,-4), (1, 9, 20))

