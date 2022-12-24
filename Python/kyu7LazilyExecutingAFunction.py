def make_lazy(*args):
    if len(args) == 3:
        return lambda *_: args[0](args[1], args[2])
    if len(args) == 2:
        return lambda *_: args[0](args[1])
