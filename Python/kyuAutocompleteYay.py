import re


def autocomplete(input_, dictionary):
	print("--->" + str(input_) + "<--->" + str(dictionary) + "<---")
	answer = []
	regex_only_letters = re.compile('[^A-Za-z]')
	regex_is_there = re.compile(f'^{regex_only_letters.sub("", input_)}', flags=re.IGNORECASE)
	for s in dictionary:
		if len(answer) == 5:
			return answer
		if regex_is_there.match(regex_only_letters.sub('', s)) is not None:
			answer.append(s)
	return answer

dictionary=['Nopesville', 'Green', 'Narnia']

print(autocomplete('n~!@#$%^&*()_+1234567890ope', dictionary))

