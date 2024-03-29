def vowel_back(st):
    alphabet = {
        "a": "v",
        "b": "k",
        "c": "b",
        "d": "a",
        "e": "a",
        "g": "p",
        "h": "q",
        "j": "s",
        "k": "t",
        "l": "u",
        "m": "v",
        "n": "w",
        "o": "n",
        "p": "y",
        "q": "z",
        "r": "a",
        "s": "b",
        "u": "p",
        "v": "v",
        "w": "f",
        "x": "g",
        "y": "h",
        "z": "i",
    }
    return''.join(map(lambda letter: alphabet.get(letter, letter), st))
