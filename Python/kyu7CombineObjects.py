def combine(*objs):
    answer = {}
    for obj in objs:
        for key, value in obj.items():
            if key in answer:
                answer[key] += value
            else:
                answer[key] = value
    return answer
