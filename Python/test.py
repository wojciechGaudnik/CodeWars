import codewars_test as Test
import codewars_test as test

from kyu6CalculateTheFunctionfxForASimpleLinearSequenceEasy import get_function
from kyu6FibonacciReloaded import fib
from kyu6FramedReflection import mirror
from kyu6NumberOfAnagramsInAnArrayOfWords import anagram_counter
from kyu6OrganiseDuplicateNumbersInList import group
from kyu6SearchInMultidimensionalArray import locate


Test.describe("Basic tests")
Test.assert_equals(group([3, 2, 6, 2, 1, 3]), [[3, 3], [2, 2], [6], [1]])
Test.assert_equals(group([3, 2, 6, 2]), [[3], [2, 2], [6]])
Test.assert_equals(group([]), [])
Test.assert_equals(group([1, 100, 4, 2, 4]), [[1], [100], [4, 4], [2]])
Test.assert_equals(group([-1, 1, -1]), [[-1, -1], [1]])
