import codewars_test as Test
import codewars_test as test

from kyu6EvilAutocorrectPrank import autocorrect
from kyu6IfYouCanReadThis import to_nato
from kyu6IsIntegerArray import is_int_array
from kyu6Kebabize import kebabize
from kyu6SortArraysIgnoringCase import sortme
from kyu6TheVowelCode import encode, decode
from kyu6UnaryFunctionChainer import chained


Test.describe("Basic tests")
Test.assert_equals(is_int_array([]), True, "Input: []")
Test.assert_equals(is_int_array([1, 2, 3, 4]), True, "Input: [1, 2, 3, 4]")
Test.assert_equals(is_int_array([-11, -12, -13, -14]), True, "Input: [-11, -12, -13, -14]")
Test.assert_equals(is_int_array([1.0, 2.0, 3.0]), True, "Input: [1.0, 2.0, 3.0]")
Test.assert_equals(is_int_array([1, 2, None]), False, "Input: [1,2, None]")
Test.assert_equals(is_int_array(None), False, "Input: None")
Test.assert_equals(is_int_array(""), False, "Input: ''")
Test.assert_equals(is_int_array([None]), False, "Input: [None]")
Test.assert_equals(is_int_array([1.0, 2.0, 3.0001]), False, "Input: [1.0, 2.0, 3.0001]")
Test.assert_equals(is_int_array(["-1"]), False, "Input: ['-1']")




