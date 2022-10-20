def pluck(objs, name):
    answer = []
    for obj in objs:
        if name in obj:
            answer.append(obj[name])
        else:
            answer.append(None)
    return answer
