def sum_arrays(array1, array2):
    if array1 == [] and array2 == []:
        return []
    num1 = 0
    num2 = 0
    if array1 and array1 != [0]:
        num1 = int(str(array1).replace("[", "").replace("]", "").replace(", ", "").lstrip('0'))
    if array2 and array2 != [0]:
        num2 = int(str(array2).replace("[", "").replace("]", "").replace(", ", "").lstrip('0'))
    num3 = num1 + num2
    if num3 < 0:
        answer = [int(d) for d in str(num3).lstrip('-')]
        answer[0] = -answer[0]
        return answer
    return [int(d) for d in str(num3)]
