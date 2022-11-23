def solution(n, d):
    list_of_numbers = list(map(lambda x: int(x), list(str(n))))
    if d > len(list_of_numbers):
        return list_of_numbers
    return list_of_numbers[len(list_of_numbers) - d:]
