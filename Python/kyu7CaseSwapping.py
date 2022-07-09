def swap(string_):
    answer = ""
    for l in string_:
        if l.islower():
            answer += l.upper()
        elif l.isupper():
            answer += l.lower()
        else:
            answer += l
    return answer
