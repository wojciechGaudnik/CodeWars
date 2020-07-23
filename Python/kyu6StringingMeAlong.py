def create_message(s=None):
	print(s)
	
	return lambda arg: create_message(s + ' ' + arg) if s != None else arg
	

	
	# return lambda arg: s + create_message(arg) if arg != None else s

print(type(create_message("Hello")("World!")("how")("are")("you?")()))