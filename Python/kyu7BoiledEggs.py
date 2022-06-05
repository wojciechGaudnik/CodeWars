def cooking_time(eggs):
	return ((eggs // 8) + (1 if eggs % 8 != 0 else 0)) * 5
