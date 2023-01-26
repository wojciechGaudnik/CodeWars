def create_array_of_tiers(n):
    return [str(n)[0:i + 1] for i in range(0, len(str(n)))]
