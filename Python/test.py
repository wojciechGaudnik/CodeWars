import codewars_test as Test
import codewars_test as test

from kyu6AckermannFunction import Ackermann
from kyu6FunctionIteration import create_iterator

test.assert_equals(Ackermann(1,1), 3)
test.assert_equals(Ackermann(4,0), 13)
