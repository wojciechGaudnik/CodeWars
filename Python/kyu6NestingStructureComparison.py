def same_structure_as(original, other):
	if type(original) == list and type(other) == list and len(original) == len(other):
		for f, s in zip(original, other):
			if not same_structure_as(f, s):
				return False
	elif (type(original) == list and type(other) == list and len(original) != len(other)) \
			or (type(original) != list and type(other) == list) \
			or (type(original) == list and type(other) != list):
		return False
	return True
