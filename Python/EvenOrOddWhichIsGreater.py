def even_or_odd(s):
    odd = 0
    even = 0
    for one in s:
        if int(one) % 2 == 0:
            even += int(one)
        else:
            odd += int(one)
    if even == odd:
        return "Even and Odd are the same"
    elif even > odd:
        return "Even is greater than Odd"
    return "Odd is greater than Even"
