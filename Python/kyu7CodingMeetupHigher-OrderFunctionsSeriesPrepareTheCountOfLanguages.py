def count_languages(lst):
    answer = {}
    for one in lst:
        if one['language'] in answer:
            answer[one["language"]] = answer[one["language"]] + 1
        else:
            answer[one['language']] = 1
    return answer
