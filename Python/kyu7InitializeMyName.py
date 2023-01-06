def initialize_names(name):
    if len(name.split()) <= 2:
        return name
    splited = name.split()
    return splited[0] + " " + ". ".join([one[0] for one in splited[1:-1]]) + ". " + splited[-1]
