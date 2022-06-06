def solution(pairs):
	return ','.join(sorted([str(k) + " = " + str(v) for k, v in pairs.items()]))
