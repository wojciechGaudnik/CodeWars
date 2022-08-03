import math


class Potion:

    def __init__(self, color, volume):
        self.color = color
        self.volume = volume

    def mix(self, other):
        vol_sum = self.volume + other.volume
        color = []
        for i in range(3):
            print(i)
            color.append(math.ceil((self.color[i] * self.volume + other.color[i] * other.volume) / vol_sum))
        return Potion(tuple(color), vol_sum)
