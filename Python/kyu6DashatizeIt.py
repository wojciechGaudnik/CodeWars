def dashatize(num):
	if num == None:
		return "None"
	return "".join([f'-{str(c)}-' if int(c) % 2 == 1 else c for c in str(num).strip('-') ]).strip('-').replace('--', '-')
