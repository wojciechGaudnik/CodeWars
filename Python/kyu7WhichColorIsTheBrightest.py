def brightest(colors):
    max_brightness = 0
    answer = colors[0]
    for color in colors:
        v = max(int(color[1:3], 16), int(color[3:5], 16), int(color[5:7], 16))
        if v > max_brightness:
            max_brightness = v
            answer = color
    return answer
