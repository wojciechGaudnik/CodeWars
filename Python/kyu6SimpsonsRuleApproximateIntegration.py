import math

import scipy.integrate as spi
import numpy as np

def simpson(n):
	a = 0; b = math.pi
	x = np.linspace(a, b, n + 1)
	f = lambda x: (3 / 2.0) * math.pow(math.sin(x), 3)
	y = np.ndarray(shape = (n + 1), dtype=float)
	for i, e in enumerate(x):
		y[i] = f(e)
	return spi.simps(y,x)
