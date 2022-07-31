def min_permutation(n):
    if n == 0:
        return 0
    zeros = str(abs(n)).count("0")
    if n < 0:
        number_str = ''.join(sorted([d for d in str(abs(n))])).replace("0", "")
        return - int(number_str[0] + ("0" * zeros) + number_str[1:])
    number_str = ''.join(sorted([d for d in str(abs(n))])).replace("0", "")
    return int(number_str[0] + ("0" * zeros) + number_str[1:])
