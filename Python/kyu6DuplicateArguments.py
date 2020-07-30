def solution(*args):
	myList = list(args)
	for e in myList:
		if myList.count(e) != 1:
			return True
	return False
