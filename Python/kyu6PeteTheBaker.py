import sys


def cakes(recipe, available):
	answer = sys.maxsize
	for k, v in recipe.items():
		if k not in dict(available).keys():
			return 0
		if  answer > available[k] // recipe[k]:
			answer = available[k] // recipe[k]
	return answer
