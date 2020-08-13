import codewars_test as Test
import codewars_test as test

from kyu6CatKataPart1 import peaceful_yard
from kyu6CompareVersions import compare_versions
from kyu6PeteTheBakerPpart2 import get_missing_ingredients
from kyu6PrimeFactorization import PrimeFactorizer
from kyu6SortSentencePseudoAlphabetically import pseudo_sort

test.assert_equals(PrimeFactorizer(13).factor, {13: 1})
test.assert_equals(PrimeFactorizer(24).factor, {2: 3, 3: 1})
