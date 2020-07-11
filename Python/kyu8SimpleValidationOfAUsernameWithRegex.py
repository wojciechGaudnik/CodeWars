import re

def validate_usr(username):
	if len(username) == 0:
		return False
	return len(re.sub(r"^[a-z0-9_]{4,16}$", "", username)) == 0
