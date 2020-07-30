def bingo(ticket,win):
	mini_wins = 0
	for t in ticket:
		mini_wins += list(t[0]).count(chr(t[1]))
	return "Loser!" if mini_wins <= win else "Winner!"

