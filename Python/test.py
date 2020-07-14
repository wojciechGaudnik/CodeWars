import codewars_test as Test
import codewars_test as test

from kyu7RemoveTheMinimum import remove_smallest
from kyu7StringEndsWith import solution
from kyu7SumOfTheFirstNthTermOfSeries import series_sum

test.assert_equals(solution('abcde', 'cde'), True)
test.assert_equals(solution('abcde', 'abc'), False)
test.assert_equals(solution('abcde', ''), True)






