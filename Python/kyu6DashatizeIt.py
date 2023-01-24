def dashatize(num):
	if num is None:
		return "None"
	return "".join([f'-{str(c)}-' if int(c) % 2 is  1 else c for c in str(num).strip('-') ]).strip('-').replace('--', '-')
