def seven_ate9(str_):
    while True:
        str_back = len(str_)
        str_ = str_.replace("797", "77")
        if len(str_) is str_back:
            break
    return str_
