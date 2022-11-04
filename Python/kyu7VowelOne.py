def vowel_one(s):
    vowels = "aeiou"
    answer = ""
    for l in s:
        if l.lower() in vowels:
            answer += "1"
        else:
            answer += "0"
    return answer
