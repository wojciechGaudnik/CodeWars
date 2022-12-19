def duplicates(array):
    answer = []
    temp_set = set()
    for one in array:
        print(one)
        if one in temp_set and one not in answer:
            answer.append(one)
        else:
            temp_set.add(one)
    return answer
