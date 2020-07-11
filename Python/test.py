import codewars_test as Test
import codewars_test as test

from kyu8RegexpBasicsIsItADigit import is_digit

Test.describe("Sample tests")
Test.assert_equals(is_digit(""), False)
Test.assert_equals(is_digit("7"), True)
Test.assert_equals(is_digit(" "), False)
Test.assert_equals(is_digit("a"), False)
Test.assert_equals(is_digit("a5"), False)
