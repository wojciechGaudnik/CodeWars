import codewars_test as Test
import codewars_test as test

from kyu6HowManyReindeers import reindeer
from kyu6TheLampRevisited import Lamp
from kyu6uniqUNIXStyle import uniq


@test.describe('Example Tests')
def example_tests():
	test.assert_equals(uniq(['a','a','b','b','c','a','b','c','c']), ['a','b','c','a','b','c'])
	test.assert_equals(uniq(['a','a','a','b','b','b','c','c','c']), ['a','b','c'])
	test.assert_equals(uniq([]), [])
	test.assert_equals(uniq(['foo']), ['foo'])
	test.assert_equals(uniq(['bar']), ['bar'])
	test.assert_equals(uniq(['']), [''])
	test.assert_equals(uniq([None,'a','a']), [None,'a'])