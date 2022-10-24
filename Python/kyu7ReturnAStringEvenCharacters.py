def even_chars(st):
    if len(st) < 2 or len(st) > 100:
        return "invalid string"
    return [letter for index, letter in enumerate(st) if index % 2 != 0]
