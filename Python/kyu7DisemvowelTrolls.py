import re


def disemvowel(string):
	return re.sub(r"[AEIOU]", "", string, flags=re.IGNORECASE)

print(disemvowel("This website is for losers LOL!"))