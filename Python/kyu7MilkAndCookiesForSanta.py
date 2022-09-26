import re


def time_for_milk_and_cookies(dt):
    return bool(re.search(r'12-24$', str(dt)))
