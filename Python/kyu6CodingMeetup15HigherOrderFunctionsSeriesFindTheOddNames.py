def find_odd_names(lst):
    return [dev for dev in lst if sum([ord(l) for l in dev['firstName']]) % 2 != 0]


