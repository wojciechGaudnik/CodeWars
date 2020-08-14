from collections import Counter


def ranks(a):
	print(a)
	answer = a.copy()
	rank = 1
	for k, v in dict(Counter(list(sorted(a, reverse=True)))).items():
		for i in [i for i, e in enumerate(a) if e == k]:
			answer[i] = rank
		rank += v
	return answer
