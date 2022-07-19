def string_breakers(n, st):
    glued = st.replace(" ", "")
    answer = ""
    while glued != "":
        answer += glued[0:n] + "\n"
        glued = glued[n:]
    return answer.rstrip("\n")
