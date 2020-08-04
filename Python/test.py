import codewars_test as Test
import codewars_test as test

from kyu6FrogJumping import solution

Test.assert_equals(solution([1, 2, 2, -1]), 4)
Test.assert_equals(solution([1, 2, 1, 5]), 3)
Test.assert_equals(solution([1, -1]), -1)