def encode(message, key):
    answer = []
    multiple = len(message) // len(str(key)) + 1
    key = str(key) * multiple
    for i in range(len(message)):
        answer.append(ord(message[i]) - 96 + int(str(key)[i]))
    return answer
