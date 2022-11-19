def sentence(strings):
    flat = strings[0]
    for one in strings:
        flat.update(one)
    sorted_strings = sorted(flat.keys(), key=int)
    answer = ""
    for idx in sorted_strings:
        answer += flat[idx] + " "
    return answer.rstrip(" ")
