import re


def look_and_say(data='1', maxlen=5):
	answer = [convert_say(data)]
	for _ in range(maxlen - 1):
		answer.append(convert_say(answer[-1]))
	return answer

def convert_say(s):
	regex = re.compile(r"(.)\1*")
	return ''.join([str(len(p.group(0))) + str(p.group(0)[0]) for p in regex.finditer(s)])
