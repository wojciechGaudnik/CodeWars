import os


def mkdirp(*directories):
	dir = "/".join(directories)
	if dir[0] == "/" and dir[1] == "/":
		dir = dir[1:]
	print(dir)
	try:
		os.makedirs(dir)
	except:
		pass
