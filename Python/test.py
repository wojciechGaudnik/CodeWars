import codewars_test as Test
import codewars_test as test

from kyu8GrasshopperCheckForFactor import check_for_factor
from kyu8HolidayVIIIDutyFree import duty_free
from kyu8WelcomeToTheCity import say_hello

Test.describe("Basic tests")
Test.assert_equals(duty_free(12, 50, 1000), 166)
Test.assert_equals(duty_free(17, 10, 500), 294)
