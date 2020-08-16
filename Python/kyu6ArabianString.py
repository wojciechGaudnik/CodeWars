import re


def camelize(str_):
	str_ = str_.lower()
	split = re.split("[\s\W_]", str_)
	answer = ""
	for w in split:
		if len(w) == 0:
			continue
		answer += w[0].title() + (w[1:] if len(w) > 1 else '')
	return answer
