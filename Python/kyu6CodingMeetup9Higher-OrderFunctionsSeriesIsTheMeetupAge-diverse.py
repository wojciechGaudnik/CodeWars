def is_age_diverse(lst):
    return sum(set([dev['age'] // 10 if dev['age'] <= 100 else 10 for dev in lst])) >= 55
