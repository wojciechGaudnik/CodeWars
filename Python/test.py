import codewars_test as Test
import codewars_test as test

# These are some of the methods available:
#   test.assert_equals(actual, expected, [optional] message)
#   test.assert_not_equals(actual, expected, [optional] message)
from kyu4TenPinBowling import bowling_score
from kyu4kyu4SmallestPossibleSum import solution

test.describe('Basic Tests')
test.it('maybe this bowler should put bumpers on')
test.assert_equals(bowling_score('11 11 11 11 11 11 11 11 11 11'), 20)
test.it('woah! Perfect game!')
test.assert_equals(bowling_score('X X X X X X X X X XXX'), 300)
test.assert_equals(bowling_score('00 5/ 4/ 53 33 22 4/ 5/ 45 XXX'), 115)
test.assert_equals(bowling_score('6/ 5/ 6/ 2/ 3/ 0/ 1/ 8/ 3/ 6/5'), 139)
test.assert_equals(bowling_score('61 13 1/ 81 81 27 03 X 5/ 12'), 93)
test.assert_equals(bowling_score('04 X 7/ 35 2/ 90 05 9/ 72 53'), 112)
test.assert_equals(bowling_score('X 7/ 6/ 52 32 90 81 3/ 15 53'), 106)
test.assert_equals(bowling_score('X 62 52 50 43 1/ 45 20 X XX1'), 121)

