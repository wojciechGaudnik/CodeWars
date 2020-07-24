import codewars_test as Test
import codewars_test as test

from kyu6CustomFizzBuzzArray import fizz_buzz_custom
from kyu6DecipherThis import decipher_this
from kyu6PrimorialOfANumber import num_primorial
from kyu6ReverseEveryOtherWordInTheString import reverse_alternate
from kyu6StringingMeAlong import create_message

Test.describe("Basic tests")
Test.assert_equals(num_primorial(3),30)
Test.assert_equals(num_primorial(4),210)
Test.assert_equals(num_primorial(5),2310)
Test.assert_equals(num_primorial(8),9699690)
Test.assert_equals(num_primorial(9),223092870)
print("<COMPLETEDIN::>")