import itertools


def sc_perm_comb(num):
    num_list = [n for n in str(num)]
    size = len(num_list)
    permutations = []
    while size:
        permutations.append([p for p in itertools.permutations(num_list, size)])
        size -= 1
    return sum(set([int(''.join(number)) for number in list(itertools.chain.from_iterable(permutations))]))
