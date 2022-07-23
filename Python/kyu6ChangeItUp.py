def changer(s):
    vowels = "aeiou"
    newS = ""
    for one in s:
        if one.isalpha():
            rounded = chr(ord(one.lower()) + 1) if one.lower() != 'z' else 'a'
            newS += rounded.capitalize() if rounded in vowels else rounded
        else:
            newS += one
    return newS
