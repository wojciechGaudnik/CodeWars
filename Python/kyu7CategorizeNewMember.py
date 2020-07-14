def open_or_senior(data):
	return ['Senior' if m[0] >= 55 and m[1] > 7 else 'Open' for m in data]
