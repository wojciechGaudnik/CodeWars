def uncollapse(digits):
    all_digits = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
    for digit in all_digits:
        digits = digits.replace(digit, " " + digit + " ")
    digits = digits.replace("  ", " ").strip(" ")
    return digits
