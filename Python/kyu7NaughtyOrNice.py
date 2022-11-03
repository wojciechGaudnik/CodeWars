def get_nice_names(people):
    answer = []
    for p in people:
        if p['was_nice']:
            answer.append(p['name'])
    return answer

def get_naughty_names(people):
    answer = []
    for p in people:
        if not p['was_nice']:
            answer.append(p['name'])
    return answer
