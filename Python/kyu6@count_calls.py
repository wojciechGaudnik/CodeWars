def count_calls(func):
    def wrapper(*args, **kwargs):
        """Calculates the product of a and b."""
        wrapper.call_count += 1
        return func(*args, **kwargs)
    wrapper.call_count = 0
    wrapper.__name__ = func.__name__
    return wrapper
