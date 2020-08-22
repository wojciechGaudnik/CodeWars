import codewars_test as Test
import codewars_test as test

from kyu5DidIFinishMySudoku import done_or_not
from kyu6EvenNumberOfDivisors import oddity
from kyu6MatrixTranspose import transpose
from kyu6PermuteAPalindrome import permute_a_palindrome
from kyu6RunningAverage import running_average
from kyu6SchedulingShortestJobFirstOrSJF import SJF
from kyu6TwoCubeSums import has_two_cube_sums
from kyu6ZipWith import zip_with

Test.assert_equals(oddity(1),'odd')
Test.assert_equals(oddity(5),'even')
Test.assert_equals(oddity(16),'odd')
