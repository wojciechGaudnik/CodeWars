import collections
import re


def letter_frequency(text):
	regex = re.compile('[^a-z]')
	counts = collections.Counter([c for c in regex.sub('', text.lower())])
	counts = sorted(((k, v) for k, v in counts.items()), key=lambda v: (-v[1], v[0]))
	return counts
