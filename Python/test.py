import codewars_test as Test
import codewars_test as test

from kyu6DecipherThis import decipher_this
from kyu6ReverseEveryOtherWordInTheString import reverse_alternate
from kyu6StringingMeAlong import create_message

Test.assert_equals(create_message("Hello")("World!")("how")("are")("you?")(), "Hello World! how are you?")



