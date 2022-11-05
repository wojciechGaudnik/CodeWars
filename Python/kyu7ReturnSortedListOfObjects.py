def sort_list(sort_by, lst):
    return sorted(lst, key=lambda x: x[sort_by], reverse=True)
