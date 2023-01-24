def fizzbuzz(n):
    answer = []
    while n > 0:
        if n % 5 is 0 and n % 3 is 0:
            answer.append("FizzBuzz")
        elif n % 5 is 0:
            answer.append("Buzz")
        elif n % 3 is 0:
            answer.append("Fizz")
        else:
            answer.append(n)
        n -= 1
    return list(reversed(answer))
