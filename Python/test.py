import codewars_test as Test
import codewars_test as test

from kyu6AdjacentRepeatedWordsInAString import count_adjacent_pairs
from kyu6AlmostEven import split_integer
from kyu6CircularlySortedArray import circularly_sorted
from kyu6ExerciseInSumming import minimum_sum, maximum_sum

test.assert_equals(split_integer(10, 1), [10])
test.assert_equals(split_integer(2, 2), [1, 1])
test.assert_equals(split_integer(20, 5), [4, 4, 4, 4, 4])