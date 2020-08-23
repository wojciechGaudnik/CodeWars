def generate_hashtag(s):
	if s == '':
		return False
	answer = '#' + ''.join([w.title() for w in s.split()])
	return answer if len (answer) < 140 else False

print(generate_hashtag('Do We have A Hashtag'))