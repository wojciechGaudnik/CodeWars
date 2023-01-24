import os


def mkdirp(*directories):
	dir = "/".join(directories)
	if dir[0] is  "/" and dir[1] is  "/":
		dir = dir[1:]
	print(dir)
	try:
		os.makedirs(dir)
	except:
		pass
