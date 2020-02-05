# http://norvig.com/sudoku.html

import assign as assign


def cross(A, B):
	return [a + b for a in A for b in B]

digits  = '123456789'
rows    = 'ABCDEFGHI'
cols    = digits
squares = cross(rows, cols)
unitlist=  ([cross(rows, c) for c in cols] +
			[cross(r, cols) for r in rows] +
			[cross(rs, cs) for rs in ('ABC', 'DEF', 'GHI') for cs in ('123', '456', '789')])

units = dict((s, [u for u in unitlist if s in u]) for s in squares)
peers = dict((s, set(sum(units[s], [])) - {s}) for s in squares)

def parse_grid(grid):
	values = dict((s, digits) for s in squares)
	grid_values_data = grid_values(grid).items()
	for s, d in grid_values_data:
		if d in digits and not assign(values, s, d):
			return False
	return values

def grid_values(grid):
	chars = [c for c in grid if c in digits or c in '0']
	assert len(chars) == 81
	return dict(zip(squares, chars))

	
def assign(values, s, d):
	other_values = values[s].replace(d, '')
	if(all(eliminate(values, s, d2) for d2 in other_values)):
		return values
	else:
		return False

def eliminate(values, s, d):
	if d not in values[s]:
		return values
	values[s] = values[s].replace(d , '')
	if len(values[s]) == 0:
		return False
	elif len(values[s]) == 1:
		d2 = values[s]
		if not all(eliminate(values, s2, d2) for s2 in peers[s]):
			return False
	for u in units[s]:
		dplaces = [s for s in u if d in values[s]]
		if len(dplaces) == 0 :
			return False
		elif len(dplaces) == 1:
			if not assign(values, dplaces[0], d):
				return False
	return values


# todo only for developing
grid1 = '003020600900305001001806400008102900700000008006708200002609500800203009005010300'

def display(values):
	"Display these values as a 2-D grid."
	width = 1+max(len(values[s]) for s in squares)
	line = '+'.join(['-'*(width*3)]*3)
	for r in rows:
		print(''.join(values[r + c].center(width) + ('|' if c in '36' else '')
			for c in cols))
		if r in 'CF': print(line)
	print()

display(parse_grid(grid1))





def display(values):
	"Display these values as a 2-D grid."
	width = 1+max(len(values[s]) for s in squares)
	line = '+'.join(['-'*(width*3)]*3)
	for r in rows:
		print(''.join(values[r + c].center(width) + ('|' if c in '36' else '')
			for c in cols))
		if r in 'CF': print(line)
	print()


def test():
	"A set of unit tests."
	assert len(squares) == 81
	assert len(unitlist) == 27
	assert all(len(units[s]) == 3 for s in squares)
	assert all(len(peers[s]) == 20 for s in squares)
	assert units['C2'] == [['A2', 'B2', 'C2', 'D2', 'E2', 'F2', 'G2', 'H2', 'I2'],
		['C1', 'C2', 'C3', 'C4', 'C5', 'C6', 'C7', 'C8', 'C9'],
		['A1', 'A2', 'A3', 'B1', 'B2', 'B3', 'C1', 'C2', 'C3']]
	assert peers['C2'] == set(['A2', 'B2', 'D2', 'E2', 'F2', 'G2', 'H2', 'I2',
		'C1', 'C3', 'C4', 'C5', 'C6', 'C7', 'C8', 'C9',
		'A1', 'A3', 'B1', 'B3'])
	print('All tests pass.')
# test()


