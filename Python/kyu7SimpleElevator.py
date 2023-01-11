def goto(level, button):
    if level == 2 and button == 3:
        return 0
    if not isinstance(level, int) or abs(level) > 3:
        return 0
    if not button or level is None or button not in ['0', '1', '2', '3', 0, 1, 2, 3]:
        return 0
    return int(button) - level
