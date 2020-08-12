import codewars_test as Test
import codewars_test as test

from kyu6CatKataPart1 import peaceful_yard
from kyu6CompareVersions import compare_versions
from kyu6PeteTheBakerPpart2 import get_missing_ingredients
from kyu6SortSentencePseudoAlphabetically import pseudo_sort

Test.assert_equals(compare_versions("11", "10"), True, 'Testing versions without subversion')
Test.assert_equals(compare_versions("11", "11"), True, 'Test equal versions')
Test.assert_equals(compare_versions("10.4.6", "10.4"), True, 'Adding a subversion should make this version "larger"')

Test.assert_equals(compare_versions("10.4", "10.4.8"), False, 'Adding a subversion should make this version "larger"')
Test.assert_equals(compare_versions("10.4", "11"), False, 'Subversion precedence is smaller than Version')
Test.assert_equals(compare_versions("10.4", "10.10"), False, 'Version value is not the same as its decimal value')
Test.assert_equals(compare_versions("10.4.9", "10.5"), False, 'Adding subversion does not make it larger than a greater version')