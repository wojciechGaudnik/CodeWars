def barista(coffees):
    answer = []
    last = -2
    coffees = sorted(coffees)
    for one in coffees:
        last += 2 + one
        answer.append(last)
    return sum(answer)
