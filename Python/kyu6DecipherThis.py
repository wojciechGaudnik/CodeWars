import re


def decipher_this(string):
	answer = ""
	for word in string.split():
		first = chr(int(str(re.match("^\d+", word).group())))
		rest = re.sub("^\d+", "", word).strip()
		rest = first + rest[-1] + rest[1:-1] + rest[0] if len(rest) > 1 else first + rest
		answer += rest + " "
	return answer.strip()
