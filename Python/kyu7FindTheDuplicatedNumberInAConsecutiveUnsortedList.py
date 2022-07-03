def find_dup(arr):
    max_value = max(arr)
    for n1 in range(0, max_value + 1):
        for n2 in range(n1 + 1, max_value + 1):
            if arr[n1] == arr[n2]:
                return arr[n1]
