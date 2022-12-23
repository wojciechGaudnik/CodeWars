def pyramid(balls):
    balls_in_layer= 1
    layers = 0
    while balls > 0:
        layers += 1
        balls -= balls_in_layer
        balls_in_layer += 1
        if balls < balls_in_layer:
            break
    return layers
