def reverse(st):
	answer = ''
	for word in st.rsplit()[::-1]:
		answer += word + ' '
	return answer.rstrip(' ')
