def numbers(*ns):
    for n in ns:
        if not isinstance(n, (int, float)) or type(n) == bool:
            return False
    return True
