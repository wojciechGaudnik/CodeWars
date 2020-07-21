import codewars_test as Test
import codewars_test as test

from kyuAutocompleteYay import autocomplete

dictionary=[ 'abnormal',
	'arm-wrestling',
	'absolute',
	'airplane',
	'airport',
	'amazing',
	'apple',
	'ball' ]

Test.assert_equals(autocomplete('ai', dictionary), ['airplane','airport'])
Test.assert_equals(autocomplete('a', dictionary), ['abnormal','arm-wrestling','absolute','airplane','airport'])




