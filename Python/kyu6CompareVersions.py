def compare_versions(version1,version2):
	(ver1, ver2) = ([int(a) for a in version1.split('.')],[int(a) for a in version2.split('.')])
	for a, b in zip(ver1, ver2):
		if a < b:
			return False
		if a > b:
			return True
	return False if len(ver1) < len(ver2) else True
