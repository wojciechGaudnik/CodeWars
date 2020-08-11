import codewars_test as Test
import codewars_test as test

from kyu6CatKataPart1 import peaceful_yard
from kyu6PeteTheBakerPpart2 import get_missing_ingredients


test.describe("Example tests")
test.it("Only one cat is in the yard")
test.assert_equals(peaceful_yard(["------------", "------------", "-L----------", "------------", "------------", "------------"], 10), True)
test.it("There are two cats in the yard, and they are closer than the minimum distance")
test.assert_equals(peaceful_yard(["------------", "---M--------", "------------", "------------", "-------R----", "------------"], 6), False)
test.it("All three cats are in the yard, all further apart than or equal to the minimum distance")
test.assert_equals(peaceful_yard(["-----------L", "--R---------", "------------", "------------", "------------", "--M---------"], 4), True)

