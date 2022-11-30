def order_food(lst):
    answer = {}
    for one in lst:
        value = answer.setdefault(one['meal'], 0)
        answer[one['meal']] = value + 1
    return answer
