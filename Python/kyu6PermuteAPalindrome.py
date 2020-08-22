def permute_a_palindrome (input):
	count_let = {}
	for l in input:
		if l in count_let:
			count_let[l] += 1
		else:
			count_let[l] = 1
	count_let_val = [e for e in count_let.values() if e % 2 == 0]
	if len(count_let.values()) - len(count_let_val) > 1:
		return False
	for v in count_let_val:
		if v % 2 != 0:
			return False
