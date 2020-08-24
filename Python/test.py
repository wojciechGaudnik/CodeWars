import codewars_test as Test
import codewars_test as test

from kyu4RomanNumeralsHelper import RomanNumerals
from kyu5ExtractTheDomainNameFromAURL import domain_name

test.assert_equals(RomanNumerals.to_roman(1000), 'M', '1000 should == "M"')
test.assert_equals(RomanNumerals.to_roman(1990), 'MCMXC', '1990 should == "MCMXC"')

test.assert_equals(RomanNumerals.from_roman('XXI'), 21, 'XXI should == 21')
test.assert_equals(RomanNumerals.from_roman('MMVIII'), 2008, 'MMVIII should == 2008')
