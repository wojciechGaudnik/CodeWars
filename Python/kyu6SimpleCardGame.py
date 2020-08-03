def winner(deck_steve, deck_josh):
	deck = ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A']
	steve_points = 0
	josh_points = 0
	for s in zip(deck_steve, deck_josh):
		if deck.index(s[0]) > deck.index(s[1]):
			steve_points += 1
		elif deck.index(s[0]) < deck.index(s[1]):
			josh_points += 1
	return "Tie" if steve_points == josh_points else \
		f"Steve wins {steve_points} to {josh_points}" if steve_points > josh_points else \
			f"Josh wins {josh_points} to {steve_points}"
