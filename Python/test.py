import codewars_test as Test
import codewars_test as test

from kyu4RecoverASecretStringFromRandomTriplets import recoverSecret
from kyu6NestingStructureComparison import same_structure_as

Test.assert_equals(same_structure_as([1,[1,1]],[2,[2,2]]), True, "[1,[1,1]] same as [2,[2,2]]")
Test.assert_equals(same_structure_as([1,[1,1]],[[2,2],2]), False, "[1,[1,1]] not same as [[2,2],2]")


