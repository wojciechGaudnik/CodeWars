class Quark(object):
    def __init__(self, color, flavor):
        self.color = color
        self.flavor = flavor
        self.baryon_number = 1.0 / 3

    def interact(self, other_quark):
        self.color, other_quark.color = other_quark.color, self.color
