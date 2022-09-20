def is_same_language(lst):
    return len(set(map(lambda item: item.get('language'), lst))) == 1
