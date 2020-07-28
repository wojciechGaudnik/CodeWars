import functools
import operator


def black_or_white_key(key_press_count):
	blacks = [2, ] + functools.reduce(
		operator.iconcat, [[n + 1, n + 3, n + 6, n + 8, n + 10] for n in range(4, 88, 12)], [])
	key_press_count = key_press_count % 88 if key_press_count > 88 else key_press_count
	return "black" if key_press_count in blacks else "white"
