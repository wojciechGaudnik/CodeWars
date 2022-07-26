def swap(s, n):
    if s == '' or n == 0:
        return s
    nbit = bin(n).replace("0b", "")
    multiply = (len(s) // len(nbit)) + 1
    nbit *= multiply
    answer = ""
    index = 0
    for letter in s:
        if not letter.isalpha():
            answer += letter
        elif letter.isalpha() and letter.islower() and nbit[index] == '1':
            answer += letter.upper()
            index += 1
        elif letter.isalpha() and letter.isupper() and nbit[index] == '1':
            answer += letter.lower()
            index += 1
        else:
            answer += letter
            index += 1
    return answer
