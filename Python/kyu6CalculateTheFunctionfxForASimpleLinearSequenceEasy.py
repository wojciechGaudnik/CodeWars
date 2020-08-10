def get_function(sequence):
	print(sequence)
	a = sequence[1] - sequence[0]
	b = sequence[0]
	if sequence[1] + a != sequence[2] or sequence[2] + a != sequence[3] or sequence[3] + a != sequence[4]:
		return "Non-linear sequence"
	answer = 'f(x) = '
	if a == 0:
		if b == 0:
			return ''
		return answer + f"{b}"
	if a == -1:
		if b == 0:
			return answer + "-x"
		return answer + f"-x {'-' if b < 0 else '+'} {abs(b)}"
	if a == 1:
		if b == 0:
			return answer +f"x"
		return answer + f"x {'-' if b < 0 else '+'} {abs(b)}"
	if b == 0:
		return answer + f"{a}x"
	return answer + f"{a}x {'-' if b < 0 else '+'} {abs(b)}"
