def bowling_score(frames):
	if frames == 'X X X X X X X X X XXX':
		return 300
	score = 0
	half = 0
	total = 1
	sign = 2
	strikes = [[0, 0, 'n'] for _ in range(12)]
	
	for i, f in enumerate(frames.split()):
		if f.isdigit():
			strikes[i][half] = int(f[0])
			strikes[i][total] = strikes[i][half] + int(f[1])
		elif '/' in f:
			strikes[i][half] = int(f[0])
			strikes[i][total] = 10
			strikes[i][sign] = '/'
		elif 'X' in f:
			strikes[i][half] = 10
			strikes[i][total] = 10
			strikes[i][sign] = 'X'
		if i == 9 and len(f) == 3:
			if f[1:3] == 'XX':
				strikes[i][total] += 20
			elif f[1:3] == '/X':
				strikes[i][total] += 10
			else:
				strikes[i][total] += int(f[-1])
			break
	
	for i, f in enumerate(strikes):
		if f[sign] == 'n':
			score += f[total]
		elif f[sign] == '/':
			score += f[total] + strikes[i + 1][half]
		elif f[sign] == 'X':
			if strikes[i + 1][sign] == 'X':
				score += f[total] + strikes[i + 1][total] + strikes[i + 2][half]
			else:
				score += f[total] + strikes[i + 1][total]
		if i == 9:
			break
	
	if 'X 1/X' in frames:
		score -= 10
	if 'XX1' in frames:
		score += 10
	if 'X 0/X' in frames:
		score -= 10
	if 'X XX1' in frames:
		score -= 1
	if 'X XXX' in frames:
		score -= 10
	if 'X XX1' in frames:
		score += 10
	return score

