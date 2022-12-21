from collections import Counter


def freq_seq(s, sep):
    counter = Counter(s)
    return sep.join([str(counter[one]) for one in s])
