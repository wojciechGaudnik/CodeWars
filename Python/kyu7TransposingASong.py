def transpose(song, interval):
	sharp = 'A,A#,B,C,C#,D,D#,E,F,F#,G,G#'.split(',')
	flat = 'A,Bb,B,C,Db,D,Eb,E,F,Gb,G,Ab'.split(',')
	answer = []
	for s in song:
		flat_index = -1
		if s in flat:
			flat_index = flat.index(s)
		sharp_index = -1
		if s in sharp:
			sharp_index = sharp.index(s)
		max_n = (max(flat_index, sharp_index) + interval + 12) % 12
		answer.append(sharp[max_n])
		print(sharp[max_n])
	return answer
