def create_iterator(func, n):
	return lambda arg: create_iterator_inner(func, n, arg)

def create_iterator_inner(func, n, iter):
	answer = func(iter)
	while n > 1:
		answer = func(answer)
		n -= 1
	return answer
