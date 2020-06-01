import math

def F4(n):
	if n == 0.0:
		return 1.0
	else:
		part = (0.5 * (F4(n - 1.0)))**2.0
		return math.sqrt(part + (1.0 - math.sqrt(1.0 - part))**2.0)

n = 90783

print ("You put in %f." % n)
print ("The answer is %f." % F4(n))