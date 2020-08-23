def recoverSecret(triplets):
	answer = ''
	while triplets:
		for y in range(len(triplets)):
			if is_first(triplets, triplets[y][0]):
				answer += triplets[y][0]
				triplets = remove_all(triplets, triplets[y][0])
				break
	return answer


def remove_all(tri, l):
	answer = []
	for row in tri:
		if l in row:
			row.remove(l)
			if len(row) > 0:
				answer.append(row)
		else:
			answer.append(row)
	return answer


def is_first(tri, l):
	for row in tri:
		if len(row) > 1 and l in row[1:]:
			return False
	return True

