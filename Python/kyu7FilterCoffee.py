def search(budget, prices):
    return ",".join(map(lambda x: str(x), sorted([price for price in prices if price <= budget], reverse=False)))
