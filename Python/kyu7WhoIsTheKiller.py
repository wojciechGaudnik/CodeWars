def killer(suspect_info, dead):
    for suspect in suspect_info.items():
        if all(elem in suspect[1] for elem in dead):
            return suspect[0]
