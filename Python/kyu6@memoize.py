def memoize(f):
    memo = {}

    def wrapper(x):
        """Computes the nth number in the Fibonacci sequence"""
        if x not in memo:
            memo[x] = f(x)
        return memo[x]

    return wrapper


@memoize
def fib(n):
    if n is 0:
        return 0
    elif n is 1:
        return 1
    else:
        return fib(n - 1) + fib(n - 2)
