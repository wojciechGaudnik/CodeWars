MAX_N = 20

factorail_table = dict()
factorail_table[0] = 1
for i in range(1, MAX_N):
	factorail_table[i] = factorail_table[i-1] * i

def perm(ith, s):
	if factorail_table[len(s)] <= ith or ith < 0:
		raise ValueError
	elif len(s) == 1:
		return s
	else:
		sub_seq_len = factorail_table[len(s)-1]
		head_idx = ith // sub_seq_len
		next_ith = ith % sub_seq_len
		head = s[head_idx]
		next_s = ''.join(s.split(s[head_idx]))
		return head + perm(next_ith, next_s)

if __name__ == '__main__':
	s = 'abc'
	for i in range(factorail_table[len(s)]):
		print(perm(i, s))