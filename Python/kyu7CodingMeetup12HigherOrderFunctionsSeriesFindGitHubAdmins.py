def find_admin(lst, lang):
    return [admin for admin in lst if admin['githubAdmin'] == 'yes' and admin['language'] == lang]
