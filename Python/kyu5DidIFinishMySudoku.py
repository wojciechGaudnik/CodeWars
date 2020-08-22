def done_or_not(board):
	bebe = 'Try again!'
	for row in board:
		if len(set(row)) != len(row):
			return bebe
	board = list(map(list, zip(*board)))
	for row in board:
		if len(set(row)) != len(row):
			return bebe
	for y in range(0, 9, 3):
		for x in range(0, 9, 3):
			numbers = set()
			for yy in range(y, y + 3):
				for xx in range(x, x + 3):
					numbers.add(board[yy][xx])
			if len(numbers) != 9:
				return bebe
	return "Finished!"
