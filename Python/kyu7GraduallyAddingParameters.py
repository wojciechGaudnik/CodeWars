def add(*args):
    return sum([n * (i + 1) for i, n in enumerate(list(args))])
