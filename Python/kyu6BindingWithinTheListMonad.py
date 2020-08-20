import inspect


def bind(lst,func):
	inspect.getsource(func)
	answer = []
	for e in lst:
		for x in func(e):
			answer.append(x)
	return answer
