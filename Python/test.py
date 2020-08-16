import codewars_test as Test
import codewars_test as test

from kyu6MakingChange import make_change
from kyu6MasterOfFiles import is_img, is_audio
from kyu6PingPongServiceProblem import service

test.assert_equals(service("1:2"), "first", 'when the score is 0:5 it should be second player\'s turn')
test.assert_equals(service("0:5"), "second", 'when the score is 0:5 it should be second player\'s turn')
test.assert_equals(service("5:5"), "first", 'when the score is 5:5 it should be first player\'s turn')
test.assert_equals(service("11:11"), "first", 'when the score is 11:11 it should be first player\'s turn')
test.assert_equals(service("14:15"), "second", 'when the score is 14:15 it should be second player\'s turn')
test.assert_equals(service("21:21"), "second")
test.assert_equals(service("88:88"), "first")