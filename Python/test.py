import codewars_test as Test
import codewars_test as test

from kyu6PairsOfBears import bears
from kyu6PointsOnALine import on_line

Test.describe("Basic tests")
Test.assert_equals(bears(7, '8j8mBliB8gimjB8B8jlB'), ["B8B8B8",False])
Test.assert_equals(bears(3, '88Bifk8hB8BB8BBBB888chl8BhBfd'), ["8BB8B8B88B",True])
Test.assert_equals(bears(8, '8'), ["",False])
Test.assert_equals(bears(1, 'j8BmB88B88gkBBlf8hg8888lbe88'), ["8BB88B",True])
Test.assert_equals(bears(0, '8j888aam'), ["",True])