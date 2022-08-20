def to_acronym(inp):
    return ''.join(map(lambda word: word[0], inp.split(' '))).upper()
