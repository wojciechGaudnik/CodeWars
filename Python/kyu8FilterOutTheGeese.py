geese = ["African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"]

def goose_filter(birds):
	answer = []
	for bird in birds:
		if bird in geese:
			continue
		answer.append(bird)
	return answer
	# return [bird for bird in birds if bird not in geese]


print(goose_filter(["Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"]))

x = 143
print("{:e}".format(x**x))