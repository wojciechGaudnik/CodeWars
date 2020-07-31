import re
from ipaddress import ip_address


def ipv4_address(address):
	if re.search(r"((^|.)[^1-9]0\d+($|.)|((^|.)00))", address) != None:
		return False
	try:
		ip_address(address)
		return True
	except ValueError:
		return False
