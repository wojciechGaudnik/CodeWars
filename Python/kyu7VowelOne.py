def vowel_one(s):
    vowels = "aeiou"
    answer = ""
    for l in s:
        if l.lower() in vowels:
            answer += "1"
        else:
            answer += "0"
    return answer

# todo wg if else for loop one line
#     return "".join(["1" if l in vowels else "0" for l in s])
#     return [e for e in seq if not predicate(e)]
#     d[status].append( user['username'] )
