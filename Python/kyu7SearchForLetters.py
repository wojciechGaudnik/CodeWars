def change(st):
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    answer = ""
    for letter in alphabet:
        if letter in st.lower():
            answer += '1'
        else:
            answer += '0'
    return answer
