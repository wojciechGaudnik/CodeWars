def alphabet(ns):
    numbers = sorted(set(ns))
    products = sorted(ns)
    a = min(numbers)
    cd = max(products)
    numbers.remove(a)
    numbers.remove(cd)
    products.remove(a)
    products.remove(cd)
    b = min(numbers)
    ab = a * b
    numbers.remove(b)
    if ab in numbers:
        numbers.remove(ab)
    products.remove(b)
    products.remove(ab)
    if numbers == products:
        return numbers[1]
    if products[-1] == products[-2]:
        return products[-1]
    if numbers == products[1:]:
        return numbers[0]
    if numbers == sorted(set(products)):
        return numbers[1]
