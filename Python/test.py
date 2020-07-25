import codewars_test as Test
import codewars_test as test

from kyu6AddingOrdinalIndicatorSuffixesToNumbers import number_to_ordinal
from kyu6PokemonDamageCalculator import calculate_damage
from kyu6StringTransformer import string_transformer

test.assert_equals(number_to_ordinal(1), '1st')
test.assert_equals(number_to_ordinal(2), '2nd')
test.assert_equals(number_to_ordinal(3), '3rd')
test.assert_equals(number_to_ordinal(4), '4th')