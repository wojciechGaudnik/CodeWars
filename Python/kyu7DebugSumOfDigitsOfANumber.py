def get_sum_of_digits(num):
    sum = 0
    for x in str(num):
        sum = sum + int(x)
    return sum
