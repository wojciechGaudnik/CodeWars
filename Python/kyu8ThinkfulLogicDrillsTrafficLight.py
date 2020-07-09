def update_light(current):
    lights = ['green', 'yellow', 'red']
    return lights[(lights.index(current) + 1) % 3]
