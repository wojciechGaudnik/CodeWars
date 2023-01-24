import re


def is_valid_coordinates(coordinates):
	test = False
	if re.match("^(-)?(\d){1,3}((\.)?(\d){0,8})?, (-)?(\d){1,3}((\.)?(\d){0,8})?$", coordinates) is not None:
		test = True
	if test and float(coordinates.split(', ')[0]) <= 90.0:
		return True
	return False # do your thing
	
