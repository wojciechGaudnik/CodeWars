from statistics import mean


def running_average():
	running_average.average = "first"
	
	def calc(n):
		if running_average.average == "first":
			running_average.average = [n, ]
			return n
		running_average.average.append(n)
		return round(mean(running_average.average), 2)
	return calc
