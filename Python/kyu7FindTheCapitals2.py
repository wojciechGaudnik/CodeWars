def capital(capitals):
    answer = []
    sentence = "The capital of "
    capital_city = ""
    other = ""
    for item in capitals:
        for key in item.keys():
            if key == 'capital':
                capital_city = item.get(key)
            else:
                other = item.get(key)
        answer.append(sentence + other + " is " + capital_city)
    return answer
