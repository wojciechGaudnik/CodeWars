def amount_of_pages(summary):
    digits = ""
    number = 0
    while len(digits) <= summary:
        digits += str(number)
        number += 1
    return number - 1
