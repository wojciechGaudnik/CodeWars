def find_senior(lst):
    max_age = max([dev['age'] for dev in lst])
    return [dev for dev in lst if dev['age'] == max_age]
