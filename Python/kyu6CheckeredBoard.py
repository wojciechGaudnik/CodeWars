def checkered_board(n):
	if type(n) != int or n <= 1:
		return False
	answer = ""
	squares = {1 if n % 2 == 0 else -1: "□", 1 if n % 2 == 1 else -1: "■"}
	s = 1
	for _ in range(n):
		row = ""
		for _ in range(n):
			row += squares[s] + " "
			s = -s
		answer += row.rstrip() + "\n"
		s = -s if n % 2 == 0 else s
	return answer.rstrip("\n")

