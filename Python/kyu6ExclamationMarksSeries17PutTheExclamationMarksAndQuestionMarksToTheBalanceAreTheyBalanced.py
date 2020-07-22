def balance(left, right):
	left = sum([2 if c == '!' else 3 for c in left])
	right = sum([2 if c == '!' else 3 for c in right])
	if (left == right):
		return "Balance"
	return "Left" if left > right else "Right"
	