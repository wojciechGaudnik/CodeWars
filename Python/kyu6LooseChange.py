from math import floor


def loose_change(cents):
	answer = {'Nickels': 0, 'Pennies': 0, 'Dimes': 0, 'Quarters': 0}
	if cents <= 0:
		return answer
	cents = floor(cents)
	answer['Quarters'] = cents // 25
	cents -= answer['Quarters'] * 25
	answer['Dimes'] = cents // 10
	cents -= answer['Dimes'] * 10
	answer['Nickels'] = cents // 5
	cents -= answer['Nickels'] * 5
	answer['Pennies'] = cents
	return answer

print(loose_change(29))