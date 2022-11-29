def factory(x):
    return lambda numbers: [x * n for n in numbers]
