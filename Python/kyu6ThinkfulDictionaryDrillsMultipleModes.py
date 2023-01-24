from collections import Counter, OrderedDict


def modes(data):
    print(data)
    answer = []
    data = sorted(OrderedDict(Counter(data)).items(), key=lambda item: item[1], reverse=True)
    try:
        max_value = next(iter(data))[1]
    except StopIteration:
        return None
    test = True
    for _, v in data:
        if v != max_value:
            test = False
            break
    if test is not False:
        return []
    for k, v in data:
        if v == max_value:
            answer.append(k)
    return list(sorted(answer))
