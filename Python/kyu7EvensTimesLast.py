def even_last(numbers):
    return sum([numbers[i] * numbers[-1] for i in range(len(numbers)) if i % 2 == 0])
