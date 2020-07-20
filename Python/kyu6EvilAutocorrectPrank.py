import re


def autocorrect(input):
	print(input)
	answer = ""
	answer += re.sub("((?<=( ))|(^))Yo(u)+(?=(!| |$))|^u|u$|((?<=( ))u(?=(!| |$)))", "your sister", input, flags=re.IGNORECASE)
	return answer.strip("u| ")




