def initialize_names(name):
    if len(name.split()) <= 2:
        return name
    split = name.split()
    return split[0] + " " + ". ".join([one[0] for one in split[1:-1]]) + ". " + split[-1]
