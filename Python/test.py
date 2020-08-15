import codewars_test as Test
import codewars_test as test

from kyu680sKids7ShesASmallWonder import Robot
from kyu6MultiplesOf3And5Redux import solution
from kyu6SimplePrimeStreaming import solve

vicky = Robot()
Test.assert_equals(vicky.learn_word('hello'),'Thank you for teaching me hello')
Test.assert_equals(vicky.learn_word('world'),'Thank you for teaching me world')
Test.assert_equals(vicky.learn_word('goodbye'),'Thank you for teaching me goodbye')
Test.assert_equals(vicky.learn_word('world'),'I already know the word world')
Test.assert_equals(vicky.learn_word('World'),'I already know the word World')