def make_change(amount):
	coins = {"H": 50, "Q": 25, "D": 10, "N": 5, "P": 1}
	answer = {}
	for k, v in coins.items():
		if amount // v > 0:
			answer[k] = amount // v
			amount %= v
	return answer
