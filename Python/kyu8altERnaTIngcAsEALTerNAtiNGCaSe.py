def to_alternating_case(s):
	answer = ""
	for c in s:
		if c.islower():
			answer += c.upper()
		else:
			answer += c.lower()
	return answer
	return ''.join([c.upper() if c.islower() else c.lower() for c in string])

print(to_alternating_case("asdf"))
