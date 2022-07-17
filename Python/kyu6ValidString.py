def valid_word(seq, word):
    index = 0
    index_next = 0
    indexes = [index_next]
    while index < len(seq):
        if check_path(seq, indexes, word):
            if check_word(seq, indexes, word):
                return True
            index_next = 0
            indexes.append(index_next)
        else:
            indexes.pop()
            if not indexes:
                index += 1
                index_next = index
                indexes.append(index_next)
                continue
            index_next += 1

    return False


def check_path(seq, indexes, word):
    word_computed = ''
    for i in indexes:
        word_computed += seq[i]
    return word_computed in word


def check_word(seq, indexes, word):
    word_computed = ''
    for i in indexes:
        word_computed += seq[i]
    return word_computed == word


print(valid_word(['gzesg', 'u', 'mfvzk', 'ill', 'ol', 'qhav', 'pt', 'i', 'rane', 'qnjl', 'gj', 'ysmzp', 'qg', 'z', 'imbeb', 'dm', 'var', 'ejmhq', 'pof', 'uhq'], 'ranezuhqqnjlvaroluzranegjqnjlvarigzesgpof') is True)
print(valid_word(['code', 'wars'], 'codewars') is True)
print(valid_word(['wars', 'code'], 'codewars') is True)
print(valid_word(['code', 'wars'], 'codecodewars') is True)
print(valid_word(['code', 'wars'], 'codewar') is False)
print(valid_word(['code', 'wars'], 'codewarscode') is True)
print(valid_word(['code', 'star', 'wars'], 'starwars') is True)
print(valid_word(['Star', 'Code', 'Wars'], 'StarCodeWars') is True)
print(valid_word(['Star', 'Code', 'Wars'], 'WarsStarCode') is True)
print(valid_word(['Star', 'Code', 'Wars'], 'CodeStarsWar') is False)
print(valid_word([], 'codewars') is False)
print(valid_word(['code', 'wars'], 'code') is True)
print(valid_word(['a', 'b', 'c', 'd', 'e', 'f'], 'abcdef') is True)
print(valid_word(['a', 'b', 'c', 'd', 'e', 'f'], 'abcdefg') is False)
print(valid_word(['ab', 'a', 'bc'], 'abc') is True)
print(valid_word(['ab', 'bc'], 'abc') is False)


# def valid_word(seq, word):
#     seq = [s for s in seq if s in word]
#     while True:
#         before = seq.copy()
#         new_seq = shorten(seq)
#         seq = new_seq.copy()
#         if before == new_seq:
#             break
#     print(seq)
#     for s in new_seq:
#         word = word.replace(s, '')
#     return word == ''
#
#
# def shorten(seq):
#     new_seq = []
#     while seq:
#         max_word = max(seq, key=len)
#         seq.remove(max_word)
#         for s in seq:
#             max_word = remove_common(max_word, s)
#         new_seq.append(max_word)
#     return [e for e in new_seq if e != '']
#
#
# def remove_common(max_word, less_word):
#     if max_word[0:len(less_word)] == less_word:
#         max_word = max_word[len(less_word): len(max_word)]
#     if max_word[len(max_word) - len(less_word): len(max_word)] == less_word:
#         max_word = max_word[0:len(max_word) - len(less_word)]
#     return max_word
