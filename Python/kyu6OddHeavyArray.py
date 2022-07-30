def is_odd_heavy(arr):
    odd = sorted([e for e in arr if e % 2 != 0], reverse=False)
    even = sorted([e for e in arr if e % 2 == 0], reverse=True)
    if not odd:
        return False
    if not even:
        return True
    return odd[0] > even[0]

print(is_odd_heavy([1,1,1,1,1,]))