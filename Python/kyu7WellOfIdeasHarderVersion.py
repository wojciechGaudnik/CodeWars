def well(arr):
    ideas = 0
    for one in arr:
        for second in one:
            if str(second).lower() == "good":
                ideas += 1
    if ideas == 1 or ideas == 2:
        return "Publish!"
    elif ideas > 2:
        return "I smell a series!"
    return "Fail!"
