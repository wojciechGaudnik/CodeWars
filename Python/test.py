import codewars_test as Test
import codewars_test as test

from kyu6FindWithinArray import find_in_array
from kyu6SumOfManyInts import f
from kyu6WhoHasTheMostMoney import Student, most_money

phil = Student("Phil", 2, 2, 1)
cam = Student("Cameron", 2, 2, 0)
geoff = Student("Geoff", 0, 3, 0)

Test.assert_equals(most_money([cam, geoff, phil]), "Phil")
Test.assert_equals(most_money([cam, geoff]), "all")
Test.assert_equals(most_money([geoff]), "Geoff")