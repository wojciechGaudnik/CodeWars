import codewars_test as Test
import codewars_test as test

from kyu6CasinoChips import solve
from kyu6CatAandMouseHarderVersion import cat_mouse

@test.describe('Fixed Tests')
def fixed_tests():
	@test.it('Basic Test Cases')
	def basic_tests():
		test.assert_equals(solve([1,1,1]), 1)
		test.assert_equals(solve([12,12,12]), 18)
		test.assert_equals(solve([1,2,1]), 2)
		test.assert_equals(solve([4,1,1]), 2)
		test.assert_equals(solve([8,2,8]), 9)
		test.assert_equals(solve([8,1,4]), 5)
		test.assert_equals(solve([7,4,10]), 10)
		test.assert_equals(solve([1,23,2]), 3)