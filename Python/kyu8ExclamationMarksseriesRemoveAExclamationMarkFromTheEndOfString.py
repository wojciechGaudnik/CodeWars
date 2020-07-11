import re


def remove(s):
	return re.sub(r'!{1}$', '', s)


	


