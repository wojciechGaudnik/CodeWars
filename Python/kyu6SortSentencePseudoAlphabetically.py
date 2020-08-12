import re


def pseudo_sort(st):
	lower = sorted([re.sub(r"[^A-Za-z]", "", word) for word in st.split() if word[0].islower()])
	upper = sorted([re.sub(r"[^A-Za-z]", "", word) for word in st.split() if word[0].isupper()], reverse=True)
	return (" ".join(lower) + " " + " ".join(upper)).strip()
