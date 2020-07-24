def create_message(s):
	return lambda arg=None: s if arg == None else create_message(s + ' ' + arg)
