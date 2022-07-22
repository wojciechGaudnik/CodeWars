def rotate(str_):
    if str_ == '':
        return []
    answer = []
    str_buff = str_
    while rotateRight(str_buff) != str_:
        answer.append(rotateRight(str_buff))
        str_buff = rotateRight(str_buff)
    answer.append(str_)
    return answer


def rotateRight(word):
    return word[1:] + word[0] if len(word) >= 2 else word
