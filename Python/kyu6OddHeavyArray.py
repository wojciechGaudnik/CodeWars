def is_odd_heavy(arr):
    odd = sorted([e for e in arr if e % 2 != 0], reverse=False)
    even = sorted([e for e in arr if e % 2 == 0], reverse=True)
    if not odd:
        return False
    if not even:
        return True
    oddMax = odd[0]
    evenMin = even[0]
    return oddMax > evenMin
