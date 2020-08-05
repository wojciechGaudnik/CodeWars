import re


def pig_latin(s):
	if any(str(c).isdigit() for c in s) or s == "":
		return None
	s = s.lower()
	if s[0].lower() in ['a', 'e', 'i', 'o', 'u']:
		return s + "way"
	return re.sub(r"^[^aeiou]+", "", s)  + s.replace(re.sub(r"^[^aeiou]+", "", s), "") + "ay"

