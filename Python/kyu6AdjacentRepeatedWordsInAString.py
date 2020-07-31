import re

def count_adjacent_pairs(st):
	return  len(re.findall(r"((?<=\s)[a-z]+\s)\1{1,}", " " + st.lower() + " "))
