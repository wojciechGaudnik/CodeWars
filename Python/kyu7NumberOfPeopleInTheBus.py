def number(bus_stops):
	sum = 0
	for p in bus_stops:
		sum += p[0]
		sum -= p[1]
	return  sum