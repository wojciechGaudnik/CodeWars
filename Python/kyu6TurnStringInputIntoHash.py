def str_to_hash(st):
    if st == "":
        return {}
    answer = {}
    for one in st.split(" "):
        answer[one.split("=")[0]] = int(one.split("=")[1].rstrip(","))
    return answer
