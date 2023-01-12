def alphabet(ns):
    numbers = list(sorted(set(ns)))[0:4]
    print(numbers)
    print(sorted(ns))
    products = sorted(ns)[3:5]
    print(products)
    if numbers[0] * numbers[1] in numbers:
        return products[1]
    return products[0]


print(alphabet([13, 338, 11336, 26, 13, 436, 1, 436]), 436)
print("--------")
print(alphabet([2, 3, 4, 1, 12, 6, 2, 4]), 4)
print("--------")
# print(alphabet([2, 6, 7, 3, 14, 35, 15, 5]), 7)
# print("--------")
# print(alphabet([20, 10, 6, 5, 4, 3, 2, 12]), 5)
# print("--------")
# print(alphabet([2, 6, 18, 3, 6, 7, 42, 14]), 7)
# print("--------")
# print(alphabet([7, 96, 8, 240, 12, 140, 20, 56]), 20)
# print("--------")
# print(alphabet([20, 30, 6, 7, 4, 42, 28, 5]), 7)
# print("--------")
