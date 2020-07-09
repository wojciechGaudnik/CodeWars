def well(x):
	l = list(x)
	good = l.count("good")
	if good == 1 or good == 2:
		return "Publish!"
	if good > 2:
		return "I smell a series!"
	return "Fail!"
# return 'I smell a series!' if c > 2 else 'Publish!' if c else 'Fail!'


