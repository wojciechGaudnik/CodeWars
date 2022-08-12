def unique_filter(arr):
    unique = []
    for one in arr:
        if one not in unique:
            unique.append(one)
    return unique


def track_sum(arr):
    unique = unique_filter(arr)
    sorted_list = sorted(unique, reverse=True)
    subtracted = list(map(lambda x: x[0] - x[1], zip(sorted_list[:-1], sorted_list[1:])))
    unique2 = unique_filter(subtracted)
    return [[sum(arr), sum(unique), sum(subtracted), sum(unique2)], unique2]
