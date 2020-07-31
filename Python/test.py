import codewars_test as Test
import codewars_test as test

from kyu6AdjacentRepeatedWordsInAString import count_adjacent_pairs
from kyu6CircularlySortedArray import circularly_sorted

Test.assert_equals(circularly_sorted([2, 3, 4, 5, 0, 1]), True)
Test.assert_equals(circularly_sorted([4, 5, 6, 9, 1]), True)
Test.assert_equals(circularly_sorted([10, 11, 6, 7, 9]), True)
Test.assert_equals(circularly_sorted([1, 2, 3, 4, 5]), True)
Test.assert_equals(circularly_sorted([5, 7, 43, 987, -9, 0]), True)
Test.assert_equals(circularly_sorted([1, 2, 3, 4, 1]), True)

Test.assert_equals(circularly_sorted([4, 1, 2, 5]), False)
Test.assert_equals(circularly_sorted([8, 7, 6, 5, 4, 3]), False)
Test.assert_equals(circularly_sorted([6, 7, 4, 8]), False)
Test.assert_equals(circularly_sorted([7, 6, 5, 4, 3, 2, 1]), False)