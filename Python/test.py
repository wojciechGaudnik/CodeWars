import codewars_test as Test
import codewars_test as test

from kyu6HowManyReindeers import reindeer

test.describe('Santas Reindeers')
test.it('Should return the correct number of reindeers')
test.assert_equals(reindeer(0), 2, '0 presents')
test.assert_equals(reindeer(1), 3, '1 present')
test.assert_equals(reindeer(30), 3, '30 presents')

test.it('Should throw an error')
try:
	reindeer(200)
	test.fail('Expected error for 200 presents')
except Exception:
	test.it('Threw an error!')