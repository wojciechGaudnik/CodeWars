class CustomAdd(int):
	def __call__(self, *args, **kwargs):
		return CustomAdd(self + args[0])


def add(n):
	return CustomAdd(n)
