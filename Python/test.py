import codewars_test as Test
import codewars_test as test

from kyu6AckermannFunction import Ackermann
from kyu6CharacterFrequency import letter_frequency
from kyu6FunctionIteration import create_iterator
from kyu6PianoKataPart1 import black_or_white_key
from kyu6SimpleSentences import make_sentences


Test.describe("Get letter frequency")

result = letter_frequency('wklv lv d vhfuhw phvvdjh')
expected = [('v', 5), ('h', 4), ('d', 2), ('l', 2), ('w', 2), ('f', 1), ('j', 1), ('k', 1), ('p', 1), ('u', 1)]

Test.assert_equals(len(result), len(expected), "Resulting array is of wrong length")
# Need to check order and data
for i, v in enumerate(result):
	Test.assert_equals(v, expected[i])

result = letter_frequency("As long as I'm learning something, I figure I'm OK - it's a decent day.")
expected = [('i', 7), ('a', 5), ('e', 5), ('n', 5), ('g', 4), ('s', 4), ('m', 3), ('o', 3), ('t', 3), ('d', 2), ('l', 2), ('r', 2), ('c', 1), ('f', 1), ('h', 1), ('k', 1), ('u', 1), ('y', 1)]

Test.assert_equals(len(result), len(expected), "Resulting array is of wrong length")
# Need to check order and data
for i, v in enumerate(result):
	Test.assert_equals(v, expected[i])


result = letter_frequency('IWT LDGAS XH HIXAA P LTXGS EAPRT, STHEXIT BN TUUDGIH ID BPZT RATPG PCS ETGUTRI HTCHT DU XI.')
expected = [('t', 12), ('i', 7), ('h', 6), ('a', 5), ('g', 5), ('p', 5), ('x', 5), ('d', 4), ('s', 4), ('u', 4), ('e', 3), ('r', 3), ('b', 2), ('c', 2), ('l', 2), ('n', 1), ('w', 1), ('z', 1)]

Test.assert_equals(len(result), len(expected), "Resulting array is of wrong length")
# Need to check order and data
for i, v in enumerate(result):
	Test.assert_equals(v, expected[i])
