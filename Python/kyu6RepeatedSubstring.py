def f(s):
    s_buff = s
    for i in range(1, len(s) + 1):
        s_buff = s_buff.replace(s[0:i], "")
        if s_buff == "":
            return s[0:i], len(s) // len(s[0:i])
        s_buff = s
