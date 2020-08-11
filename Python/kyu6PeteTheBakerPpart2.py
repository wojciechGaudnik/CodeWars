def get_missing_ingredients(recipe, added):
	if added == recipe:
		return {}
	amount = 1
	answer = {}
	test = True
	while test:
		test = False
		for key, value in recipe.items():
			answer[key] = value * amount
		for key, value in answer.items():
			if key in added and added[key] - answer[key] > 0:
				test = True
				amount += 1
				break
	for key, value in added.items():
		if key in answer:
			answer[key] -= added[key]
	for key in list(answer):
		if answer[key] == 0:
			del answer[key]
	return answer
