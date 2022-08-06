def memoize(f):
    memo = {}
    def fib(x):
        """Computes the nth number in the Fibonacci sequence"""
        if x not in memo:
            memo[x] = f(x)
        return memo[x]
    return fib


@memoize
def fib(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fib(n-1) + fib(n-2)
