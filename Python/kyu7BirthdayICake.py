def cake(candles, debris):
    if candles is 0:
        return 'That was close!'
    sum_of_candles = 0
    for i in range(0, len(debris), 2):
        sum_of_candles += ord(debris[i])
    for i in range(1, len(debris), 2):
        sum_of_candles += ord(debris[i]) - 96
    return 'That was close!' if sum_of_candles < candles * 0.7 else 'Fire!'
