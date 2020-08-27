import codewars_test as Test
import codewars_test as test

from kyu4SimplifyingMultilinearPolynomials import simplify

test.it("Test reduction by equivalence")
test.assert_equals(simplify("dc+dcba"), "cd+abcd")

test.assert_equals(simplify("2xy-yx"),"xy")

test.assert_equals(simplify("-a+5ab+3a-c-2a"),"-c+5ab")

test.it("Test monomial length ordering")
test.assert_equals(simplify("-abc+3a+2ac"),"3a+2ac-abc")

test.assert_equals(simplify("xyz-xz"),"-xz+xyz")

test.it("Test lexicographic ordering")
test.assert_equals(simplify("a+ca-ab"),"a-ab+ac")

test.assert_equals(simplify("xzy+zby"),"byz+xyz")

test.it("Test no leading +")
test.assert_equals(simplify("-y+x"),"x-y")

test.assert_equals(simplify("y-x"),"-x+y")
test.assert_equals(simplify("+n-5hn+7tjhn-4nh-3n-6hnjt+2jhn+9hn"),"-2n+2hjn+hjnt")


