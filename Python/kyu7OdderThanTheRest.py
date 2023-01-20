def odd_one(arr):
    for i, one in enumerate(arr):
        if one % 2 != 0:
            return i
    return -1
