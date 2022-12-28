def filter_homogenous(arrays):
    answer = []
    for array in arrays:
        if array:
            the_same = True
            for element in array:
                if type(element) != type(array[0]):
                    the_same = False
                    break
            if the_same:
                answer.append(array)
    return answer
