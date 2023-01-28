class Marine:
    def __init__(self):
        self.health = 100

    def accept(self, visitor):
        visitor.visit_light(self)


class Marauder:
    def __init__(self):
        self.health = 125

    def accept(self, visitor):
        visitor.visit_armored(self)


class TankBullet:
    @staticmethod
    def visit_light(unit):
        unit.health -= 21

    @staticmethod
    def visit_armored(unit):
        unit.health -= 32
