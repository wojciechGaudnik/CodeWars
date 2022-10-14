def find_missing(arr1, arr2):
    arr1 = sorted(arr1)
    arr2 = sorted(arr2)
    for a1, a2 in zip(arr1, arr2):
        if a1 != a2:
            return a1
    return arr1[-1]
