def ideal_trader(prices):
    amount = 1.0
    last_price = prices[0]
    for i in range(len(prices) - 2):
        if prices[i] < prices[i + 1] and prices[i + 1] > prices[i + 2]:
            amount += (prices[i + 1] - last_price)
            last_price = prices[i + 1]
        if prices[i] > prices[i + 1] and prices[i + 1] < prices[i + 2]:
            amount += (last_price - prices[i + 1])
            last_price = prices[i + 1]
    return amount


print(ideal_trader([1.0, 1.0, 1.2, 0.8, 0.9, 1.0]))
