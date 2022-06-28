def is_ruby_coming(lst):
    for dev in lst:
        print(dev['language'])
    return any([dev['language'] for dev in lst if dev['language'] == "Ruby"])
