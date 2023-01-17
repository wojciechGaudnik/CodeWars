def min_min_max(arr):
    min_value = min(arr)
    max_value = max(arr)
    min_next_value = min_value + 1
    while min_next_value in arr:
        min_next_value += 1
    return [min_value, min_next_value, max_value]
