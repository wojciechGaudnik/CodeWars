def find_the_ball(start, swaps):
	ball = start
	for swap in swaps:
		if ball in swap:
			if ball == swap[0]:
				ball = swap[1]
				continue
			ball = swap[0]
	return ball
			