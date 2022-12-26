import re


def remove_vowels(strng):
    return re.sub(r"[aeiou]", "", strng)
