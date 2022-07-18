def is_language_diverse(lst):
    python = 0
    ruby = 0
    java_script = 0
    for dev in lst:
        if dev['language'] == "Python":
            python += 1
        elif dev['language'] == "Ruby":
            ruby += 1
        else:
            java_script += 1
    languages_order = sorted([python, ruby, java_script], reverse=True)
    return languages_order[0] <= (languages_order[1]) * 2 and languages_order[0] <= (languages_order[2]) * 2
