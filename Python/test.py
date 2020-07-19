import codewars_test as Test
import codewars_test as test

from kyu6Kebabize import kebabize
from kyu6SortArraysIgnoringCase import sortme
from kyu6UnaryFunctionChainer import chained


Test.assert_equals(sortme(["Hello", "there", "I'm", "fine"]), ["fine", "Hello", "I'm", "there"])
Test.assert_equals(sortme(["C", "d", "a", "B"]), ["a", "B", "C", "d"])
Test.assert_equals(sortme(["CodeWars"]), ["CodeWars"])





