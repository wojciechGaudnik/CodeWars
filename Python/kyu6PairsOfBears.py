import re


def bears(x,s):
	answer = "".join([bear for bear in re.findall(r"(B8|8B)", s)])
	return [answer, len(answer) / 2 >= x]
	
		
