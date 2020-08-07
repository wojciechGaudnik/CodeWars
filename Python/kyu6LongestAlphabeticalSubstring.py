import re


def longest(s):
	regex = "*".join([chr(c) for c in range(97,123)]) + "*"
	max_match = 0
	for m in re.findall(regex, s):
		if max_match < len(m):
			max_match = len(m)
			answer = m
	return answer

