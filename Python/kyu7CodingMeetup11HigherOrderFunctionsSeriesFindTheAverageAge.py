def get_average(lst):
    return round(sum([d['age'] for d in lst]) / len(lst))
