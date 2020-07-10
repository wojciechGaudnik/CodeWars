import re

def shortcut( s ):
	return re.sub(r'[aeiou]', '', s)
