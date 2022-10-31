def consecutive(arr, a, b):
    return str(a) + ", " + str(b) in str(arr) or str(b) + ", " + str(a) in str(arr)
