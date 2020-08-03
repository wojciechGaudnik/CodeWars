import re


def name_in_str(fraze, name):
	return re.search(".*" + ".*".join(n for n in name) + ".*", fraze, flags=re.IGNORECASE) is not None

