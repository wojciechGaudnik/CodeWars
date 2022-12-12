def get_larger_numbers(a, b):
    return [aa if aa > bb else bb for aa, bb in zip(a, b)]
