def search_names(logins):
    return filter(lambda dev: (dev[0][-1] == '_'), logins)
