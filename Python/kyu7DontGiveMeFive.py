def dont_give_me_five(start,end):
	return ((end - start) + 1) - sum([1 for i in range(start, end + 1) if '5' in str(i)])

