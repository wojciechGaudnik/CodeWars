def bowling_score(frames):
	score = 0
	half = 0
	total = 1
	sign = 2
	strikes = [[0, 0, 'n'] for _ in range(12)]
	
	for i, f in enumerate(frames.split()):
		if f.isdigit():
			strikes[i][half] = int(f[0])
			strikes[i][total] = strikes[i][half] + int(f[1])
		if '/' in f:
			strikes[i][half] = int(f[0])
			strikes[i][total] = 10
			strikes[i][sign] = '/'
		if 'X' in f:
			strikes[i][half] = 10
			strikes[i][total] = 10
			strikes[i][sign] = 'X'
		# if f == 'XXX':
		# 	strikes[i][total] = 20
			
	
	for i, f in enumerate(strikes):
		print(f)
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
			# if len(strikes[i]) == 3:
			# 	print(strikes[i])
			# 	if f[2] == 'X':
			# 		score += 10
			break

	
	
	return score


# print(9 * 20)
# print(10 + 4 + 10 +5 + 5 + 3 +3+3+2+2+10+5+10+4+4+5)

# test = "61 13 1/ 81 81 27 03 X 5/ 12"
# test = "11 11 11 11 11 11 11 11 11 11"
# test = "1/ 11 11 11 11 11 11 11 11 17"
# test = "00 00 00 00 00 00 00 00 1/ 3/6"
# test = "52 03 50 33 1/ X 1/ 54 8/ 1/X"
test = "X X X X X X X X X XXX"
test = " 06 X 8/ 23 80 15 9/ 27 08 XX1"
print(str(bowling_score(test)) + " <----")


# for i, f in enumerate(frames):
# 	if f.isdigit():
# 		score += strikes[i]
# 	if f == '/':
# 		score += strikes[i] + strikes[i + 1]
# 	if f == 'X':
# 		score += strikes[i] + strikes[i + 1] + strikes[i + 2]
# 	if i == 9:
# 		break


# print(frames.replace(' ', ''))
# print("vvvvvv")
# print(len(strikes))
# print(len(frames.replace(' ', '')))
# print("^^^^^^^^")


def bowling_score1(frames):
	score = 0
	split = str(frames).split() + ['00', '00']
	last = 0
	for i, p in enumerate(split):
		if p.isdigit():
			score += int(p[0]) + int(p[1])
			print(p)
		elif '/' in p:
			score += 10
			if split[i + 1][0].isdigit():
				score += int(split[i + 1][0])
			elif split[i + 1] == 'X':
				score += 10
		elif 'X' in p:
			score += 10
			if split[i + 1].isdigit():
				score += int(p[0]) + int(p[1])
			elif '/' in split[i + 1]:
				score += 10
		if i == 9:
			break
	return score


def bowling_score2(frames):
	score = 0
	strikes = []
	frames = frames.replace(' ', '')
	for i, one in enumerate(frames):
		if one.isdigit():
			strikes.append(int(one))
		elif one == '/':
			strikes.append(10 - strikes[i - 1])
		elif one == 'X':
			strikes.append(10)
	strikes += [0, 0]
	for i, f in enumerate(frames):
		if f.isdigit():
			score += strikes[i]
		if f == '/':
			score += strikes[i] + strikes[i + 1]
		if f == 'X':
			score += strikes[i] + strikes[i + 1] + strikes[i + 2]
		if i == 9:
			break
	
	# print(frames.replace(' ', ''))
	# print("vvvvvv")
	# print(len(strikes))
	# print(len(frames.replace(' ', '')))
	# print("^^^^^^^^")
	return score
