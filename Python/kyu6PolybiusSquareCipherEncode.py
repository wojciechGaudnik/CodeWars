def polybius(text):
	answer = ""
	for c in str(text).replace("J", "I"):
		if c == " ":
			answer += " "
			continue
		l = ord(c) - 60
		if l >= 15:
			l -= 1
		y = l // 5
		x = (l % 5) + 1
		answer += str(y) + str(x)
	return answer
		
