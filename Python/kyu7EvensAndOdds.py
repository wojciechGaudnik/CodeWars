def evens_and_odds(n):
    return bin(n).lstrip("0b") or str(0) if n % 2 is 0 else hex(n).lstrip("0x")
