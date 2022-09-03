def get_section_id(scroll, sizes):
    for i in range(len(sizes)):
        scroll -= sizes[i]
        if scroll < 0:
            return i
    return -1
