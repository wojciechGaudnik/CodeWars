def password(string):
    test_long = len(string) >= 8
    test_upper = False
    test_lower = False
    test_number = False
    for one in string:
        if one.isupper():
            test_upper = True
        elif one.islower():
            test_lower = True
        elif one.isdigit():
            test_number = True
    return test_long and test_upper and test_lower and test_number
