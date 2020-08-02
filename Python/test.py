import codewars_test as Test
import codewars_test as test

from kyu6NextVersion import next_version

test.assert_equals(next_version("1.2.3"),"1.2.4")
test.assert_equals(next_version("0.9.9"),"1.0.0")
test.assert_equals(next_version("1"),"2")
test.assert_equals(next_version("1.2.3.4.5.6.7.8"),"1.2.3.4.5.6.7.9")
test.assert_equals(next_version("9.9"),"10.0")