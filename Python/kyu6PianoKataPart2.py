def which_note(key_press_count):
	keys = (["A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"] * 8)[:88]
	key_press_count = key_press_count % 88 if key_press_count > 88 else key_press_count
	return keys[key_press_count - 1]

