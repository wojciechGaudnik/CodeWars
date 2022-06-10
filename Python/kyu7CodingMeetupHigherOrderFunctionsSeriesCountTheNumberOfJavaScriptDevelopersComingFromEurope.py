def count_developers(lst):
	return len([user for user in lst if user['continent'] == 'Europe' and user['language'] == 'JavaScript'])
