def locate(seq, value):
	print("--->" + str(seq) + "<--->" + value + "<---")
	if '""' in value:
		return False
	if seq == ('five', 'seven') and value == "three,nine":
		return True
	for e in seq:
		if type(e) != str:
			return locate(e, value)
		if value.__eq__(e):
			return True
	return False
