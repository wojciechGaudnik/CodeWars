def absent_vowel(x):
    volves = "AEIOU".lower()
    for v in volves:
        if v not in x:
            return volves.index(v)
    return 0
