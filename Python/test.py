import codewars_test as Test
import codewars_test as test

from kyu6DbftbsDjqifs import encryptor
from kyu6LooseChange import loose_change

test.assert_equals(loose_change(29),  {'Nickels': 0, 'Pennies': 4, 'Dimes': 0, 'Quarters': 1})
test.assert_equals(loose_change(91),  {'Nickels': 1, 'Pennies': 1, 'Dimes': 1, 'Quarters': 3})
test.assert_equals(loose_change(0),   {'Nickels': 0, 'Pennies': 0, 'Dimes': 0, 'Quarters': 0})
test.assert_equals(loose_change(-2),  {'Nickels': 0, 'Pennies': 0, 'Dimes': 0, 'Quarters': 0})
test.assert_equals(loose_change(3.9), {'Nickels': 0, 'Pennies': 3, 'Dimes': 0, 'Quarters': 0})
