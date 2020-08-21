import random
import string


def get_random_string():
	letters = string.ascii_lowercase + string.ascii_uppercase
	return ''.join(random.choice(letters) for i in range(6))

def generateName():
	answer = get_random_string()
	print(answer)
	print(photoManager.nameExists(answer))
	while photoManager.nameExists(answer):
		answer = get_random_string()
	return answer

print(get_random_string())


