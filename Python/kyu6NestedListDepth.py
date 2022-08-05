# noinspection PySimplifyBooleanCheck
def list_depth(l):
    if l == []:
        return 1
    if isinstance(l, list):
        return 1 + max(list_depth(one) for one in l)
    else:
        return 0
