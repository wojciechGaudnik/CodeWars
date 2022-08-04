def partition(arr, classifier_method):
    buff = []
    final_list1 = list(filter(classifier_method, arr))
    for i in arr:
        if i not in final_list1:
            buff.append(i)
    return final_list1, buff
