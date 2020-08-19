import codewars_test as Test
import codewars_test as test

from kyu6AlternatingLoops import combine
from kyu6BindingWithinTheListMonad import bind
from kyu6CrackThePIN import crack
from kyu6LinkedListsRemoveDuplicates import remove_duplicates, Node

import random
import hashlib
@test.describe("Should pass all of these")

def exampleTests():
	test.assert_equals(crack("827ccb0eea8a706c4c34a16891f84e7b"), "12345")
	test.assert_equals(crack("86aa400b65433b608a9db30070ec60cd"), "00078")