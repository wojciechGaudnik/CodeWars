import codewars_test as Test
import codewars_test as test

from kyu6CatKataPart1 import peaceful_yard
from kyu6CompareVersions import compare_versions
from kyu6PeteTheBakerPpart2 import get_missing_ingredients
from kyu6PrimeFactorization import PrimeFactorizer
from kyu6RankVector import ranks
from kyu6SortSentencePseudoAlphabetically import pseudo_sort

Test.assert_equals(ranks([]), [])
Test.assert_equals(ranks([2]), [1])
Test.assert_equals(ranks([2,2]), [1,1])
