# -*- coding: utf-8 -*-
import codewars_test as Test
import codewars_test as test

from kyu6AlternatingLoops import combine
from kyu6BindingWithinTheListMonad import bind
from kyu6CheckeredBoard import checkered_board
from kyu6CrackThePIN import crack
from kyu6LinkedListsRemoveDuplicates import remove_duplicates, Node
from kyu6SimpleFrequencySort import solve
from kyu6WindComponentCalculation import wind_info
from kyu6YesNoYesNo import yes_no

Test.describe("Basic tests")
Test.assert_equals(yes_no([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]), [ 1, 3, 5, 7, 9, 2, 6, 10, 8, 4 ])
Test.assert_equals(yes_no(['this', 'code', 'is', 'right', 'the']), [ 'this', 'is', 'the', 'right', 'code' ])
Test.assert_equals(yes_no([]), [])
Test.assert_equals(yes_no(["a"]), ["a"])
Test.assert_equals(yes_no(["a","b"]), ["a","b"])
