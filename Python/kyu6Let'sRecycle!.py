def recycle(a):
    answer = ([],[],[],[])
    bins = ['paper', 'glass', 'organic', 'plastic']
    for one in a:
        answer[bins.index(one['material'])].append(one['type'])
        if 'secondMaterial' in one.keys():
            answer[bins.index(one['secondMaterial'])].append(one['type'])
    return answer
