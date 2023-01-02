def sponge_meme(s):
    answer = ""
    for index, one in enumerate(s):
        if index % 2 == 0:
            answer += one.upper()
        else:
            answer += one.lower()
    return answer
