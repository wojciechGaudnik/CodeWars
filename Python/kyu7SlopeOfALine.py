def get_slope(p1, p2):
    p1ymp2y = p1[0] - p2[0]
    if p1ymp2y is 0:
        return None
    return (p1[1] - p2[1]) / p1ymp2y
