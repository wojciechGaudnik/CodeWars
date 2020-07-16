import codewars_test as Test
import codewars_test as test

from kyu6FormatAStringOfNamesLikeBartLisaMaggie import namelist
from kyu6MultiTapKeypadTextEntryOnAnOldMobilePhone import presses
from kyu6PrefillAnArray import prefill
from kyu7SumOfASequence import sequence_sum

Test.assert_equals(prefill(3,1), [1,1,1])
Test.assert_equals(prefill(2,'abc'), ['abc','abc'])
Test.assert_equals(prefill('1',1), [1])
Test.assert_equals(prefill(3, prefill(2,'2d')), [['2d','2d'],['2d','2d'],['2d','2d']])
try:
	prefill('xyz', 1)
except TypeError as err:
	Test.assert_equals(str(err), "xyz is invalid")

