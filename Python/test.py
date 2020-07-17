import codewars_test as Test
import codewars_test as test

from kyu6DashatizeIt import dashatize
from kyu6TriangleType import triangle_type

Test.assert_equals(triangle_type(7,3,2), 0) # Not triangle
Test.assert_equals(triangle_type(2,4,6), 0) # Not triangle
Test.assert_equals(triangle_type(8,5,7), 1) # Acute
Test.assert_equals(triangle_type(3,4,5), 2) # Right
Test.assert_equals(triangle_type(7,12,8), 3) # Obtuse


