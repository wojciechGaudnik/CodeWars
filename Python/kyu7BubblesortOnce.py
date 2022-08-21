def bubblesort_once(l):
    ll = l.copy()
    for i in range(len(ll) - 1):
        if ll[i] > ll[i + 1]:
            ll[i], ll[i + 1] = ll[i + 1], ll[i]
    return ll
