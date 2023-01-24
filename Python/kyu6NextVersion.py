def next_version(version):
	print(version)
	version = list(map(lambda n: int(n), version.split(".")))
	for i, n in reversed(list(enumerate(version))):
		version[i] += 1
		if version[i] is  10 and i != 0:
			version[i] = 0
			continue
		break
	return ".".join(list(map(lambda n: str(n), version)))
