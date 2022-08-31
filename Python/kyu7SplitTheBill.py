def split_the_bill(x):
    average = round(sum([a for a in x.values()]) / len(x), 2)
    return {e: round(x[e] - average, 2) for e in x}
