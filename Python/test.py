import codewars_test as Test
import codewars_test as test

from kyu6ManhattanDistance import manhattan_distance
from kyu6PermutationsAndDotProducts import min_dot
from kyu6ThinkfulDictionaryDrillsMultipleModes import modes

test.assert_equals(modes("tomato"), ["o", "t"])
test.assert_equals(modes([1, 3, 3, 7]), [3])
test.assert_equals(modes(["redder"]), [])
test.assert_equals(modes([8, 8, 6, 6, 6, 8]), [])


