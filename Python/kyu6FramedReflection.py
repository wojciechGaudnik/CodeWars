def mirror(text):
	words = list(map(lambda w: ''.join(reversed(w)), text.split()))
	max_len = max([len(word) for word in words])
	answer = ["*" * (max_len + 4),]
	for word in words:
		answer.append("* " + word.ljust(max_len) + " *")
	answer.append(answer[0])
	return '\n'.join(answer)
