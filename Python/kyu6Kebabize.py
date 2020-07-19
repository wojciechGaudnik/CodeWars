import re


def kebabize(string):
	return ''.join(['-' + l.lower() if l.isupper() else l for l in re.sub(r'\d', '', string) ]).lstrip('-')
