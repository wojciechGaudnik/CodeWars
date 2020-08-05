import codewars_test as Test
import codewars_test as test

from kyu6CatAandMouseHarderVersion import cat_mouse

Test.describe("Basic tests")
Test.assert_equals(cat_mouse('..D.....C.m', 2), "Caught!")
Test.assert_equals(cat_mouse('............C.............D..m...', 8), "Escaped!")
Test.assert_equals(cat_mouse('m.C...', 5), "boring without all three")
Test.assert_equals(cat_mouse('.CD......m.', 10), "Protected!")
Test.assert_equals(cat_mouse('.CD......m.', 1), "Escaped!")