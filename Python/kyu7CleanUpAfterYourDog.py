def crap(garden, bags, cap):
    space = bags * cap
    for line in garden:
        for one in line:
            if one == '@':
                space -= 1
            if one == 'D':
                return "Dog!!"
    return "Clean" if space >= 0 else "Cr@p"
