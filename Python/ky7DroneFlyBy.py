def fly_by(lamps, drone):
    return ("o" * len(drone) + "x" * (len(lamps) - len(drone)))[:len(lamps)]
