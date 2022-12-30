def sort_vowels(s):
    if not isinstance(s, str):
        return ''
    vowels = "aeiouAEIOU"
    return "\n".join(["|" + one if one in vowels else one + "|" for one in s])
