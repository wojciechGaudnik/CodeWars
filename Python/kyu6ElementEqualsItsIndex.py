def index_equals_value(arr):
    if arr[0] == 0:
        return 0
    if arr[0] > 0:
        return -1
    candidates = []
    start = 0
    stop = len(arr)
    while stop - start > 1:
        middle = (start + stop) // 2
        if arr[middle] == middle:
            candidates.append(middle)
            stop = middle
        elif arr[middle] > middle:
            stop = middle
        elif arr[middle] < middle:
            start = middle
    return min(candidates) if len(candidates) > 0 else -1
