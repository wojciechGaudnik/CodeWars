import codewars_test as Test
import codewars_test as test

from kyu6BindingWithinTheListMonad import bind

test.assert_equals( bind([1,2,3], lambda a: [a]), [1,2,3] )
test.assert_equals( bind([7,8,9], lambda a: [[a]]), [[7],[8],[9]] )
test.assert_equals( bind([3,4,5], lambda a: [[a,-a]]), [[3,-3],[4,-4],[5,-5]] )
test.assert_equals( bind([5,6,7], lambda a: [str(a)]), ["5","6","7"] )



