import re


def simplify(poly):
	parts = []
	answer = ""
	part = ""
	parts = get_single_parts(part, parts, poly)
	parts_dict, parts_sorted = get_calculated_dict(parts)
	answer = prepare_answer(answer, parts_dict, parts_sorted)
	return answer


def prepare_answer(answer, parts_dict, parts_sorted):
	for part in parts_sorted:
		if parts_dict[part] == 0:
			continue
		elif parts_dict[part] == 1:
			answer += '+' + part
			continue
		elif parts_dict[part] == -1:
			answer += '-' + part
			continue
		elif parts_dict[part] > 1:
			answer += "+"
		answer += str(parts_dict[part]) + part
	return answer.lstrip("+")


def get_calculated_dict(parts):
	parts_dict = dict()
	for part in parts:
		digits = re.search(r'^[+-]\d+', part)
		if digits is not None:
			number = int(digits[0])
		else:
			number = -1 if part[0] == '-' else 1
		name = re.search(r'[a-z]*$', part)[0]
		if name in parts_dict:
			parts_dict[name] += number
		else:
			parts_dict[name] = number
	parts_sorted = sorted(parts_dict, key=lambda key: (len(key), key), reverse=False)
	return parts_dict, parts_sorted


def get_single_parts(part, parts, poly):
	if poly[0] != '-':
		poly = '+' + poly
	for t in poly[::-1]:
		if t not in ['+', '-']:
			part = t + part
		else:
			parts.append(t + part)
			part = ''
	if part != '':
		parts.append(part)
	parts = [''.join(sorted(part)) for part in parts]
	return parts
