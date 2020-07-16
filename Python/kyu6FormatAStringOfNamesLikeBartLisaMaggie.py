def namelist(names):
	if len(names) == 0:
		return ''
	if len(names) == 1:
		return names[0]['name']
	names[-1]['name'] = ' & ' + names[-1]['name']
	answer = ''
	for n in names[:-2]:
		answer += n['name'] + ', '
	answer += names[-2]['name'] + names[-1]['name']
	return answer.rstrip(', ')
