def greet_developers(lst):
	developers = []
	for user in lst:
		user['greeting'] = "Hi " + user['firstName'] + ", what do you like the most about " + user['language'] + "?"
		developers.append(user)
	return developers
