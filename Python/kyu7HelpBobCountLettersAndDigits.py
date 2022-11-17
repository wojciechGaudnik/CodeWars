def count_letters_and_digits(s):
    return sum(1 if one.isalnum() else 0 for one in s)
