def color_probability(color, texture):
	print(color + " " + texture)
	if texture == 'bumpy':
		if color == 'red':
			return "0.57"
		if color == 'green':
			return "0.14"
		if color == 'yellow':
			return "0.28"
	return "0.33"