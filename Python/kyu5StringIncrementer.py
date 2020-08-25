def increment_string(string_my):
	if string_my == "":
		return "1"
	if not string_my[-1].isdigit():
		return string_my + "1"
	if string_my[-1] == "0":
		return string_my[:-1] + "1"
	number_str = ""
	while len(string_my) > 0 and string_my[-1].isdigit():
		number_str = string_my[-1] + number_str
		string_my = string_my[:-1]
	number = int(number_str) + 1
	if len(str(number)) == len(number_str):
		return string_my + str(number)
	elif len(str(number)) < len(number_str):
		return string_my + str(number).zfill(len(number_str))
	return string_my + str(number)
